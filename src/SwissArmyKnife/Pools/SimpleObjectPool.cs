using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwissArmyKnife.Pools
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <remarks>
    /// This type is threadsafe
    /// </remarks>
    public sealed class SimpleObjectPool<T> : ObjectPool<T> where T : PoolableObject
    {
        private readonly object _lock;
        private readonly Stack<T> _objectStack;

        /// <summary>
        /// Initializes a new instance of <see cref="SimpleObjectPool{T}"/>
        /// </summary>
        public SimpleObjectPool()
            :this(10)
        {            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="capacity"></param>
        public SimpleObjectPool(int capacity)
        {
            if (capacity < 1)
                throw new ArgumentOutOfRangeException(nameof(capacity));

            this._lock = new object();
            this._objectStack = new Stack<T>(capacity);
            this.Count = 0;
        }

        /// <summary>
        /// Add a <see cref="PoolableObject"/> to the pool
        /// </summary>
        /// <param name="objectToAdd">
        /// The object to add to the pool
        /// </param>
        public sealed override void Add(T objectToAdd)
        {
            if (objectToAdd == null)
                throw new ArgumentNullException(nameof(objectToAdd));
            if (this.Count == this._objectStack.Count)
                throw new InvalidOperationException("The pool is full and no more objects can be added");

            lock (this._lock)
            {
                this._objectStack.Push(objectToAdd);
            }
        }

        /// <summary>
        /// Get a <see cref="PoolableObject"/> from the pool
        /// </summary>
        /// <returns>
        /// A <see cref="PoolableObject"/> from the pool or null
        /// when the pool is exhausted
        /// </returns>
        public sealed override T Get()
        {
            lock (this._lock)
            {
                T result = null;

                if (this._objectStack.Count > 0)
                {
                    result = this._objectStack.Pop();
                }

                return result;
            }
        }

        /// <summary>
        /// Return or add a <see cref="PoolableObject"/> to the pool
        /// </summary>
        /// <param name="objectToReturn">
        /// The <see cref="PoolableObject"/> to return to the pool
        /// </param>
        /// <remarks>
        /// Returning an object to a full <see cref="ObjectPool{T}"/>
        /// silently disposes the returned object
        /// </remarks>
        public sealed override void Return(T objectToReturn)
        {
            if (objectToReturn == null)
                throw new ArgumentNullException(nameof(objectToReturn));

            lock (this._lock)
            {
                if (this.Count != this._objectStack.Count)
                {
                    objectToReturn.Dispose();
                    this._objectStack.Push(objectToReturn);
                }
                else
                {
                    objectToReturn = null;
                }
            }
        }
    }
}
