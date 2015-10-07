namespace SwissArmyKnife.Pools
{
    /// <summary>
    /// Represents a pool for long-lived reusable objects
    /// </summary>
    public interface IObjectPool
    {
        /// <summary>
        /// Add a <see cref="PoolableObject"/> to the pool
        /// </summary>
        /// <param name="objectToAdd">
        /// The object to add to the pool
        /// </param>
        /// <typeparam name="T">
        /// The type of the object to add to the pool
        /// </typeparam>
        void Add<T>(T objectToAdd) where T : PoolableObject;

        /// <summary>
        /// Get a <see cref="PoolableObject"/> from the pool
        /// </summary>
        /// <returns>
        /// A <see cref="PoolableObject"/> from the pool or null
        /// when the pool is exhausted
        /// </returns>
        /// <typeparam name="T">
        /// The type of the object to get from the pool
        /// </typeparam>
        T Get<T>() where T : PoolableObject;

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
        bool TryGet<T>(out T objectFromPool) where T : PoolableObject;

        /// <summary>
        /// Return or add a <see cref="PoolableObject"/> to the pool
        /// </summary>
        /// <param name="objectToReturn">
        /// The <see cref="PoolableObject"/> to return to the pool
        /// </param>
        /// <typeparam name="T">
        /// The type of the object to return to the pool
        /// </typeparam>
        void Return<T>(T objectToReturn) where T : PoolableObject;
    }
}
