using System;
using System.Collections;
using System.Collections.Generic;

namespace SwissArmyKnife.Pools
{
    /// <summary>
    /// A generic <see cref="IObjectPool"/> for multiple types
    /// </summary>
    /// <remarks>
    /// This type is threadsafe
    /// </remarks>
    public sealed class GenericObjectPool : IObjectPool
    {
        private readonly object _lock;
        private readonly Dictionary<Type, Stack> _stacks;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericObjectPool"/>
        /// </summary>
        public GenericObjectPool()
        {
            this._lock = new object();
            this._stacks = new Dictionary<Type, Stack>(5);
        }

        /// <summary>
        /// Add a <see cref="PoolableObject"/> to the pool
        /// </summary>
        /// <param name="objectToAdd">
        /// The object to add to the pool
        /// </param>
        public void Add<T>(T objectToAdd) where T : PoolableObject
        {
            if (objectToAdd == null)
                throw new ArgumentNullException(nameof(objectToAdd));

            lock (this._lock)
            {
                Type originType = objectToAdd.GetType();
                Stack typeStack;

                if (!this._stacks.TryGetValue(originType, out typeStack))
                {
                    typeStack = new Stack();
                    this._stacks.Add(originType, typeStack);
                }

                objectToAdd.Pool = this;
                typeStack.Push(objectToAdd);
            }
        }

        /// <summary>
        /// Get a <see cref="PoolableObject"/> from the pool
        /// </summary>
        /// <returns>
        /// A <see cref="PoolableObject"/> from the pool or null
        /// when the pool is exhausted
        /// </returns>
        public T Get<T>() where T : PoolableObject
        {
            T result = null;

            Type originType = typeof(T);
            Stack typeStack;

            lock (this._lock)
            {
                if (this._stacks.TryGetValue(originType, out typeStack)
                    && typeStack.Count != 0)
                {
                    result = (T)typeStack.Pop();
                }
            }

            return result;
        }

        /// <summary>
        /// Try to get a <see cref="PoolableObject"/> from the pool
        /// </summary>
        /// <typeparam name="T">
        /// The type of the object to get from the pool
        /// </typeparam>
        /// <param name="objectFromPool">
        /// </param>
        /// <returns>
        /// True when an object was retrieved from the pool, false otherwise
        /// </returns>
        public bool TryGet<T>(out T objectFromPool) where T : PoolableObject
        {
            bool result = false;

            objectFromPool = this.Get<T>();
            if (objectFromPool != null)
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Return or add a <see cref="PoolableObject"/> to the pool
        /// </summary>
        /// <param name="objectToReturn">
        /// The <see cref="PoolableObject"/> to return to the pool
        /// </param>
        /// <remarks>
        /// Returning an object to a full <see cref="IObjectPool"/>
        /// silently disposes the returned object
        /// </remarks>
        public void Return<T>(T objectToReturn) where T : PoolableObject
        {
            if (objectToReturn == null)
                throw new ArgumentNullException(nameof(objectToReturn));

            this.Add<T>(objectToReturn);
        }
    }
}
