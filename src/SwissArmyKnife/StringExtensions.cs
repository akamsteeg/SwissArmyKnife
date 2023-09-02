using System;
using System.Collections.Generic;

namespace SwissArmyKnife
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

        #region IsNullOrEmpty

        /// <summary>
        /// Indicates whether the specified string is null or a <see cref="string"/>.Empty string
        /// </summary>
        /// <param name="source"></param>
        /// <returns>
        /// True if the value parameter is null or an empty string (""); otherwise, false
        /// </returns>
        public static bool IsNullOrEmpty(this string source) =>
            string.IsNullOrEmpty(source);

        #endregion

        #region IsNullOrWhitespace

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only
        /// of white-space characters
        /// </summary>
        /// <param name="source">
        /// </param>
        /// <returns>
        /// true if the value parameter is null or System.String.Empty, or if
        /// value consists exclusively of white-space characters
        /// </returns>
        public static bool IsNullOrWhiteSpace(this string source) => 
            string.IsNullOrWhiteSpace(source);

    #endregion

        #region Contains

        /// <summary>
        /// Returns a value indicating whether a specified substring occurs
        /// within this string
        /// </summary>
        /// <param name="source">
        /// </param>
        /// <param name="value">
        /// The string to seek
        /// </param>
        /// <param name="comparisonType">
        /// One of the enumeration values that specifies the rules for the search
        /// </param>
        /// <returns>
        /// true if the value parameter occurs within this string, or if value is
        /// the empty string (""); otherwise, false
        /// </returns>
        public static bool Contains(this string source, string value, StringComparison comparisonType)
        {
            if (value == null) // No string.IsNullOrEmpty() because Contains(string) returns true when the input is an empty string and we mimick that here
                throw new ArgumentNullException(nameof(value));

            var result = (value == string.Empty || (source.IndexOf(value, comparisonType) != -1));

            return result;
        }

        #endregion

        #region  IsAnyOf

        /// <summary>
        /// Checks if the string is equal to the supplied value
        /// </summary>
        /// <param name="source">
        /// </param>
        /// <param name="comparisonType">
        /// One of the enumeration values that specifies how the strings will be compared
        /// </param>
        /// <param name="value">
        /// The value to check the object against
        /// </param>
        /// <returns>
        /// True if the object is equal to the value, false otherwise
        /// </returns>
        public static bool IsAnyOf(this string source, StringComparison comparisonType, string value) =>
            source.Equals(value, comparisonType);

        /// <summary>
        /// Checks if the string is equal to any of the supplied values
        /// </summary>
        /// <param name="source">
        /// </param>
        /// <param name="comparisonType">
        /// One of the enumeration values that specifies how the strings will be compared
        /// </param>
        /// <param name="value0">
        /// The first value to check the string against
        /// </param>
        /// <param name="value1">
        /// The second value to check the string against
        /// </param>
        /// <returns>
        /// True if the string is equal to any of the values, false otherwise
        /// </returns>
        public static bool IsAnyOf(this string source, StringComparison comparisonType, string value0, string value1) =>
            source.Equals(value0, comparisonType)
            || source.Equals(value1, comparisonType);

        /// <summary>
        /// Checks if the string is equal to any of the supplied values
        /// </summary>
        /// <param name="source">
        /// </param>
        /// <param name="comparisonType">
        /// One of the enumeration values that specifies how the strings will be compared
        /// </param>
        /// <param name="value0">
        /// The first value to check the string against
        /// </param>
        /// <param name="value1">
        /// The second value to check the string against
        /// </param>
        /// <param name="value2">
        /// The third value to check the string against
        /// </param>
        /// <returns>
        /// True if the string is equal to any of the values, false otherwise
        /// </returns>
        public static bool IsAnyOf(this string source, StringComparison comparisonType, string value0, string value1, string value2) =>
            source.Equals(value0, comparisonType)
            || source.Equals(value1, comparisonType)
            || source.Equals(value2, comparisonType);

        /// <summary>
        /// Checks if the string is equal to any of the supplied values
        /// </summary>
        /// <param name="source">
        /// </param>
        /// <param name="comparisonType">
        /// One of the enumeration values that specifies how the strings will be compared
        /// </param>
        /// <param name="value0">
        /// The first value to check the string against
        /// </param>
        /// <param name="value1">
        /// The second value to check the string against
        /// </param>
        /// <param name="value2">
        /// The third value to check the string against
        /// </param>
        /// <param name="value3">
        /// The third value to check the string against
        /// </param>
        /// <returns>
        /// True if the string is equal to any of the values, false otherwise
        /// </returns>
        public static bool IsAnyOf(this string source, StringComparison comparisonType, string value0, string value1, string value2, string value3) =>
            source.Equals(value0, comparisonType)
            || source.Equals(value1, comparisonType)
            || source.Equals(value2, comparisonType)
            || source.Equals(value3, comparisonType);

        /// <summary>
        /// Checks if the string is equal to any of the supplied values
        /// </summary>
        /// <param name="source">
        /// </param>
        /// <param name="comparisonType">
        /// One of the enumeration values that specifies how the strings will be compared
        /// </param>
        /// <param name="values">
        /// The values to check the string against
        /// </param>
        /// <returns>
        /// True if the string is equal to any of the values, false otherwise
        /// </returns>
        public static bool IsAnyOf(this string source, StringComparison comparisonType, params string[] values) =>
            IsAnyOfInternal(source, comparisonType, values);

        /// <summary>
        /// Checks if the string is equal to any of the supplied values
        /// </summary>
        /// <param name="source">
        /// </param>
        /// <param name="comparisonType">
        /// One of the enumeration values that specifies how the strings will be compared
        /// </param>
        /// <param name="values">
        /// The values to check the string against
        /// </param>
        /// <returns>
        /// True if the string is equal to any of the values, false otherwise
        /// </returns>
        public static bool IsAnyOf(this string source, StringComparison comparisonType, IEnumerable<string> values) =>
            IsAnyOfInternal(source, comparisonType, values);

        /// <summary>
        /// Checks if the string is equal to any of the supplied values
        /// </summary>
        /// <param name="source">
        /// The current object to compare the values against
        /// </param>
        /// <param name="comparisonType">
        /// One of the enumeration values that specifies how the strings will be compared
        /// </param>
        /// <param name="values">
        /// The values to check the string against
        /// </param>
        /// <returns>
        /// True if the string is equal to any of the values, false otherwise
        /// </returns>
        private static bool IsAnyOfInternal(string source, StringComparison comparisonType, IEnumerable<string> values)
        {
            var result = false;

            foreach (var currentValue in values)
            {
                result = source.Equals(currentValue, comparisonType);

                if (result)
                    break;
            }

            return result;
        }



        #endregion
    }
}
