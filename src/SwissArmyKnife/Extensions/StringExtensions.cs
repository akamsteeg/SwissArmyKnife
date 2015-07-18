using System;

namespace SwissArmyKnife.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="String"/>
    /// </summary>
    public static class StringExtensions
    {
        #region FormatWith()

        /// <summary>
        /// Replaces the format item in a specified string with the string
        /// representation of the specified object
        /// </summary>
        /// <param name="source">
        /// A composite format string
        /// </param>
        /// <param name="arg0">
        /// The object to format
        /// </param>
        /// <returns>
        /// A copy of the string in which any format items are replaced by the
        /// string representation of arg0
        /// </returns>
        public static string FormatWith(this string source, object arg0) =>
            string.Format(source, arg0);

        /// <summary>
        /// Replaces the format items in a specified string with the string
        /// representation of two specified objects
        /// </summary>
        /// <param name="source">
        /// A composite format string
        /// </param>
        /// <param name="arg0">
        /// The first object to format
        /// </param>
        /// <param name="arg1">
        /// The second object to format
        /// </param>
        /// <returns>
        /// A copy of the string in which any format items are replaced by the
        /// string representation of arg0 and arg1
        /// </returns>
        public static string FormatWith(this string source, object arg0, object arg1) =>
            string.Format(source, arg0, arg1);

        /// <summary>
        /// Replaces the format items in a specified string with the string
        /// representation of three specified objects
        /// </summary>
        /// <param name="source">
        /// A composite format string
        /// </param>
        /// <param name="arg0">
        /// The first object to format
        /// </param>
        /// <param name="arg1">
        /// The second object to format
        /// </param>
        /// <param name="arg2">
        /// The third object to format
        /// </param>
        /// <returns>
        /// A copy of the string in which any format items are replaced by the
        /// string representation of arg0, arg1 and arg2
        /// </returns>
        public static string FormatWith(this string source, object arg0, object arg1, object arg2) =>
            string.Format(source, arg0, arg1, arg2);

        /// <summary>
        /// Replaces the format items in a specified string with the string
        /// representation of three specified objects
        /// </summary>
        /// <param name="source">
        /// A composite format string
        /// </param>
        /// <param name="arg0">
        /// The first object to format
        /// </param>
        /// <param name="arg1">
        /// The second object to format
        /// </param>
        /// <param name="arg2">
        /// The third object to format
        /// </param>
        /// <param name="arg3">
        /// The fourth object to format
        /// </param>
        /// <returns>
        /// A copy of the string in which any format items are replaced by the
        /// string representation of arg0, arg1 and arg2
        /// </returns>
        public static string FormatWith(this string source, object arg0, object arg1, object arg2, object arg3) =>
            string.Format(source, arg0, arg1, arg2, arg3);

        /// <summary>
        /// Replaces the format item in a specified string with the string
        /// representation of a corresponding object in a specified array
        /// </summary>
        /// <param name="source">
        /// A composite format string
        /// </param>
        /// <param name="args">
        /// An object array that contains zero or more objects to format
        /// </param>
        /// <returns>
        /// A copy of the string in which the format items have been replaced by
        /// the string representation of the corresponding objects in args
        /// </returns>
        public static string FormatWith(this string source, params object[] args) =>
            string.Format(source, args);

        /// <summary>
        /// Replaces the format item in a specified string with the string
        /// representation of a corresponding object in a specified array
        /// </summary>
        /// <param name="source">
        /// A composite format string
        /// </param>
        /// <param name="formatProvider">
        /// An object that supplies culture-specific formatting information
        /// </param>
        /// <param name="args">
        /// An object array that contains zero or more objects to format
        /// </param>
        /// <returns>
        /// A copy of the string in which the format items have been replaced by
        /// the string representation of the corresponding objects in args
        /// </returns>
        public static string FormatWith(this string source, IFormatProvider formatProvider, params object[] args) =>
            string.Format(formatProvider, source, args);

        #endregion

        #region Truncate()

        /// <summary>
        /// Truncates this instance to the specified length
        /// </summary>
        /// <param name="source"></param>
        /// <param name="length">The length to truncate to</param>
        /// <returns>The truncated <see cref="string"/></returns>
        public static string Truncate(this string source, int length)
        {
            if (length < 1)
                throw new ArgumentOutOfRangeException(nameof(length));
            if (length > source.Length)
                throw new ArgumentOutOfRangeException(nameof(length), "Length must refer to a location within the string");

            return source.Substring(0, length);
        }

        /// <summary>
        /// Truncates this instance to the specified length
        /// </summary>
        /// <param name="source"></param>
        /// <param name="length">The length to truncate to</param>
        /// <param name="suffix">The suffix to append to the truncated <see cref="string"/></param>
        /// <returns>The truncated <see cref="string"/></returns>
        public static string Truncate(this string source, int length, string suffix) =>
            source.Truncate(length) + suffix;

        #endregion
    }
}
