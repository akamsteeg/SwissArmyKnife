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
        new void Dispose();
    }
}