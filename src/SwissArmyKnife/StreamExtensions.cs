﻿using System;
using System.IO;

namespace SwissArmyKnife
{
    /// <summary>
    /// 
    /// </summary>
    public static class StreamExtensions
    {
#if NET35 // || DEBUG

        private const int _defaultBufferSize = 4096;

        /// <summary>
        /// Reads the bytes from the current stream 
        /// and writes them to another stream
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination">
        /// The stream to which the contents of the 
        /// current stream will be copied
        /// </param>
        public static void CopyTo(this Stream source, Stream destination)
        {
            source.CopyTo(destination, _defaultBufferSize);
        }

        /// <summary>
        /// Reads the bytes from the current stream 
        /// and writes them to another stream, using 
        /// a specified buffer size
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination">
        /// The stream to which the contents of the 
        /// current stream will be copied
        /// </param>
        /// <param name="bufferSize">
        /// The size of the buffer. This value must 
        /// be greater than zero
        /// </param>
        public static void CopyTo(this Stream source, Stream destination, int bufferSize)
        {
            if (!source.CanRead && !source.CanWrite)
                throw new ObjectDisposedException(null, "Stream is disposed");
            if (!source.CanRead)
                throw new NotSupportedException("Cannot read from source stream");
            if (destination == null)
                throw new ArgumentNullException(nameof(destination));
            if (!destination.CanRead && !destination.CanWrite)
                throw new ObjectDisposedException(nameof(destination), "Destination stream is disposed");
            if (!destination.CanWrite)
                throw new NotSupportedException("Cannot write to destination stream");
            if (bufferSize < 1)
                throw new ArgumentOutOfRangeException("nameof(bufferSize), Buffer size must be 1 or higher");

            var buffer = new byte[bufferSize];

            int read = -1;
            while (read != 0)
            {
                read = source.Read(buffer, 0, bufferSize);
                destination.Write(buffer, 0, read);
            }
        }
#endif

        /// <summary>
        /// Reset the position within the stream 
        /// back to the beginning
        /// </summary>
        /// <param name="source"></param>
        public static void Reset(this Stream source)
        {
            if (!source.CanRead && !source.CanWrite)
                throw new ObjectDisposedException(nameof(source));
            if (!source.CanSeek)
                throw new NotSupportedException("Cannot seek in the stream");

            source.Seek(0, SeekOrigin.Begin);
        }
    }
}
