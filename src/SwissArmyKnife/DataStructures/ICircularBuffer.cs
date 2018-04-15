using System.Collections;
using System;

namespace SwissArmyKnife.DataStructures
{
    /// <summary>
    /// Represents a circular buffer
    /// </summary>
    public interface ICircularBuffer
      : IEnumerable
    {
        /// <summary>
        /// Gets the size of the buffer
        /// </summary>
        int Size { get; }

        /// <summary>
        /// Gets the number of items in the buffer
        /// </summary>
        int Count { get; }
    }

    /// <summary>
    /// Represents a strongly-typed circular buffer
    /// </summary>
    /// <typeparam name="T">
    /// The type of items stored in the buffer
    /// </typeparam>
    public interface ICircularBuffer<T>
        : ICircularBuffer
    {
        /// <summary>
        /// Add an item to the buffer
        /// </summary>
        /// <param name="itemToAdd">
        /// The item to add to the buffer
        /// </param>
        /// <returns>
        /// The overwritten item in the buffer, or default when the position in
        /// the buffer was empty
        /// </returns>
        T Add(T itemToAdd);

        /// <summary>
        /// Get the current item from the buffer
        /// </summary>
        /// <returns>
        /// The current item, or default if the position was empty
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Is thrown when the buffer is empty
        /// </exception>
        T Get();
    }
}
