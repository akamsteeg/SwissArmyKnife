namespace SwissArmyKnife.Pools
{
    /// <summary>
    /// Represents a pool for long-lived reusable objects
    /// </summary>
    /// <typeparam name="T">
    /// The type of the objects to pool
    /// </typeparam>
    public abstract class ObjectPool<T> where T : PoolableObject
    {
        /// <summary>
        /// Gets the number of items in the cache
        /// </summary>
        public int Count
        {
            get;
            protected set;
        }

        /// <summary>
        /// Add a <see cref="PoolableObject"/> to the pool
        /// </summary>
        /// <param name="objectToAdd">
        /// The object to add to the pool
        /// </param>
        public abstract void Add(T objectToAdd);

        /// <summary>
        /// Get a <see cref="PoolableObject"/> from the pool
        /// </summary>
        /// <returns>
        /// A <see cref="PoolableObject"/> from the pool or null
        /// when the pool is exhausted
        /// </returns>
        public abstract T Get();

        /// <summary>
        /// Return or add a <see cref="PoolableObject"/> to the pool
        /// </summary>
        /// <param name="objectToReturn">
        /// The <see cref="PoolableObject"/> to return to the pool
        /// </param>
        public abstract void Return(T objectToReturn);
    }
}
