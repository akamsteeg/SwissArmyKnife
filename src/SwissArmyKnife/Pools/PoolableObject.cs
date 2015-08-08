﻿using System;

namespace SwissArmyKnife.Pools
{
    /// <summary>
    /// Base class for poolable objectss
    /// </summary>
    public abstract class PoolableObject : IDisposable
    {
        /// <summary>
        /// Gets or sets the managing <see cref="ObjectPool"/> for this object
        /// </summary>
        public ObjectPool Pool
        {
            get;
            set;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting
        /// unmanaged resources and return it to the <see cref="ObjectPool"/>
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
        /// Return this instance back to the <see cref="ObjectPool"/>
        /// </summary>
        /// <param name="disposing"></param>
        private void Dispose(bool disposing)
        {
            this.Pool.Return(this);
        }
    }
}