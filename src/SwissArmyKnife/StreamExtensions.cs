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
#if NET35
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public static void CopyTo(this Stream source, Stream destination)
        {
            source.CopyTo(destination, 4096);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="bufferSize"></param>
        public static void CopyTo(this Stream source, Stream destination, int bufferSize)
        {
            if (destination == null)
                throw new ArgumentNullException(nameof(destination));
            if (bufferSize < 1)
                throw new ArgumentOutOfRangeException("Buffer size must be 1 or higher", nameof(bufferSize));
            if (!source.CanRead)
                throw new NotSupportedException("Cannot read from source stream");
            if (!destination.CanWrite)
                throw new NotSupportedException("Cannot write to destination stream");

            var buffer = new byte[bufferSize];
            while (source.Position + bufferSize <= source.Length)
            {
                source.Read(buffer, 0, bufferSize);
                destination.Write(buffer, 0, bufferSize);
            }
        }
#endif
    }
}
