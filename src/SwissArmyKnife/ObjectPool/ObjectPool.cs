namespace SwissArmyKnife.ObjectPool
{
    /// <summary>
    /// Represents a pool for long-lived reusable objects
    /// </summary>
    public abstract class ObjectPool<T> where T : PoolableObject
    {
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
