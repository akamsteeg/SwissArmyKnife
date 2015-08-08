using System;
using System.IO;

namespace SwissArmyKnife.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Stream"/>
    /// </summary>
    public static class StreamExtensions
    {
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
