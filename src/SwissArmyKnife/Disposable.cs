using System;
using System.Threading;

namespace SwissArmyKnife
{
    /// <summary>
    /// Implements the Disposable pattern and is used
    /// as a base class for disposable resources
    /// </summary>
    /// <remarks>
    /// This class is thread-safe
    /// </remarks>
    public abstract class Disposable : IDisposable
    {
        /// <summary>
        /// Holds the value to track the disposed state. As
        /// long as the value is 0 the object is not disposed
        /// </summary>
        private int _disposed;

        /// <summary>
        /// Gets the state of the disposable object
        /// </summary>
        protected bool IsDisposed
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Disposable"/>
        /// </summary>
        protected Disposable()
        {
            this._disposed = 0;
        }

        /// <summary>
        /// Performs application-defined tasks associated with 
        /// freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (Interlocked.CompareExchange(ref this._disposed, 1, 0) == 0)
            {
                this.Dispose(true);
                /*
                 * We cannot simply let the getter of IsDisposed check for the value of
                 * this._disposed, because it would be true after the 
                 * Interlocked.CompareExchange(). Any Dispose(bool) implementations 
                 * checking for the value of  IsDisposed to avoid double disposing a 
                 * managed resource would fail then.
                 */
                this.IsDisposed = true;
                GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with 
        /// freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <param name="disposing">
        /// True when disposing, false when finalizing
        /// </param>
        protected abstract void Dispose(bool disposing);

        /// <summary>
        /// Utility method for throwing an <see cref="ObjectDisposedException"/>
        /// when this <see cref="Disposable"/> object is disposed
        /// </summary>
        protected void ThrowIfDisposed()
        {
            if (this.IsDisposed)
                throw new ObjectDisposedException(this.GetType().FullName);
        }
    }
}