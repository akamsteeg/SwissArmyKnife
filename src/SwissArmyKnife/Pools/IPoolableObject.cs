using System;

namespace SwissArmyKnife.Pools
{
    /// <summary>
    /// Represents poolable objects
    /// </summary>
    public interface IPoolableObject
      : IDisposable
    {
        /// <summary>
        /// Gets or sets the managing <see cref="IObjectPool"/> for this object
        /// </summary>
        IObjectPool Pool { get; set; }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting
        /// unmanaged resources and return it to the <see cref="IObjectPool"/>
        /// </summary>
        /// <example>
        /// public void Dispose()
        /// {
        ///     // Reset the object for reuse
        ///     
        ///     // Return it to the pool
        ///     GC.SuppressFinalize(this);
        ///     this.Pool.Return(this);
        /// }
        /// </example>
        new void Dispose();
    }
}