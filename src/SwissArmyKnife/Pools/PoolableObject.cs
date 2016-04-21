using System;

namespace SwissArmyKnife.Pools
{
    /// <summary>
    /// Base class for poolable objects
    /// </summary>
    public abstract class PoolableObject 
        : IPoolableObject
    {
        /// <summary>
        /// Gets or sets the managing <see cref="IObjectPool"/> for this object
        /// </summary>
        public IObjectPool Pool
        {
            get;
            set;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting
        /// unmanaged resources and return it to the <see cref="IObjectPool"/>
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Resets the instance to its initial state. Free, release or reset managed resources
        /// </summary>
        protected abstract void Reset();

        /// <summary>
        /// Return this instance back to the <see cref="IObjectPool"/>
        /// </summary>
        /// <param name="disposing"></param>
        private void Dispose(bool disposing)
        {
            this.Reset();
            this.Pool.Return(this);
        }
    }
}
