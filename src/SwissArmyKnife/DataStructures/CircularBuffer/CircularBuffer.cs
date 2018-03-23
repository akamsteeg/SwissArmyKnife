using System;
using System.Collections;
using System.Collections.Generic;

namespace SwissArmyKnife.DataStructures.CircularBuffer
{
    /// <summary>
    /// Represents a strongly typed circular buffer
    /// 
    /// This class is thread-safe
    /// </summary>
    /// <typeparam name="T">
    /// The type of items stored in the buffer
    /// </typeparam>
    public sealed class CircularBuffer<T>
        : ICircularBuffer<T>
    {
        /// <summary>
        /// Gets the size of the buffer
        /// </summary>
        public int Size
        {
            get;
        }

        /// <summary>
        /// Gets the number of items in the buffer
        /// </summary>
        public int Count
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the array to buffer data in
        /// </summary>
        private readonly T[] _buffer;

        /// <summary>
        /// Gets the position in the buffer where the tail is
        /// </summary>
        private int _tail;

        /// <summary>
        /// Gets the position in the buffer where the head is
        /// </summary>
        private int _head;

        /// <summary>
        /// Gets the object to lock on for thread safety
        /// </summary>
        private readonly object _lock;

        /// <summary>
        /// Initializes a new instance of <see cref="CircularBuffer{T}"/>
        /// </summary>
        /// <param name="size">
        /// The size of the buffer
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Is thrown when the specified size is less than 1
        /// </exception>
        public CircularBuffer(int size)
        {
            if (size < 1)
                throw new ArgumentOutOfRangeException(nameof(size), $"'{nameof(size)}' must be greater than 0");

            this.Size = size;
            this.Count = 0;

            this._tail = 0;
            this._head = size - 1;

            this._buffer = new T[size];
            this._lock = new object();
        }

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
        public T Add(T itemToAdd)
        {
            lock (this._lock)
            {
                this._head = (this._head + 1) % this.Size;

                var result = this._buffer[this._head];

                this._buffer[this._head] = itemToAdd;

                if (this.Count == this.Size)
                {
                    this._tail = (this._tail + 1) % this.Size;
                }
                else
                {
                    this.Count++;
                }

                return result;
            }
        }

        /// <summary>
        /// Get the current item from the buffer
        /// </summary>
        /// <returns>
        /// The current item, or default if the position was empty
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Is thrown when the buffer is empty
        /// </exception>
        public T Get()
        {
            lock (this._lock)
            {
                if (this.Count == 0)
                    throw new InvalidOperationException("Cannot get item from empty buffer");

                var result = this._buffer[this._tail];
                this._buffer[this._tail] = default(T);


                this._tail = (this._tail + 1) % Size;
                this.Count--;

                return result;
            }
        }

        /// <summary>
        /// Returns an <see cref="IEnumerator{T}"/> that iterates through this
        /// <see cref="CircularBuffer{T}"/>
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerator{T}"/> that iterates through this <see cref="CircularBuffer{T}"/>
        /// </returns>
        public IEnumerator<T> GetEnumerator()
        {
            while (this.Count > 0)
            {
                yield return this.Get();
            }
        }

        /// <summary>
        /// Returns an <see cref="IEnumerator"/> that iterates through this
        /// <see cref="CircularBuffer{T}"/>
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerator"/> that iterates through this <see cref="CircularBuffer{T}"/>
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
