using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SwissArmyKnife
{
    /// <summary>
    /// 
    /// </summary>
    public static class StreamExtensions
    {
#if NET35  || DEBUG

        private const int _defaultBufferSize = 4096;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public static void CopyTo(this Stream source, Stream destination)
        {
            source.CopyTo(destination, _defaultBufferSize);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="bufferSize"></param>
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
    }
}
