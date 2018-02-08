using System;

namespace SwissArmyKnife
{
    /// <summary>
    /// Extension methods for <see cref="int"/>
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Gets a <see cref="TimeSpan"/> for the specified number of milliseconds
        /// </summary>
        /// <param name="value">
        /// The value to convert
        /// </param>
        /// <returns>
        /// The <see cref="TimeSpan"/> for the specified number of milliseconds
        /// </returns>
        public static TimeSpan MilliSeconds(this int value) =>
          TimeSpan.FromMilliseconds(value);

        /// <summary>
        /// Gets a <see cref="TimeSpan"/> for the specified number of seconds
        /// </summary>
        /// <param name="value">
        /// The value to convert
        /// </param>
        /// <returns>
        /// The <see cref="TimeSpan"/> for the specified number of seconds
        /// </returns>
        public static TimeSpan Seconds(this int value) =>
          TimeSpan.FromSeconds(value);

        /// <summary>
        /// Gets a <see cref="TimeSpan"/> for the specified number of minutes
        /// </summary>
        /// <param name="value">
        /// The value to convert
        /// </param>
        /// <returns>
        /// The <see cref="TimeSpan"/> for the specified number of minutes
        /// </returns>
        public static TimeSpan Minutes(this int value) =>
          TimeSpan.FromMinutes(value);

        /// <summary>
        /// Gets a <see cref="TimeSpan"/> for the specified number of hours
        /// </summary>
        /// <param name="value">
        /// The value to convert
        /// </param>
        /// <returns>
        /// The <see cref="TimeSpan"/> for the specified number of hours
        /// </returns>
        public static TimeSpan Hours(this int value) =>
          TimeSpan.FromHours(value);

        /// <summary>
        /// Gets a <see cref="TimeSpan"/> for the specified number of days
        /// </summary>
        /// <param name="value">
        /// The value to convert
        /// </param>
        /// <returns>
        /// The <see cref="TimeSpan"/> for the specified number of days
        /// </returns>
        public static TimeSpan Days(this int value) =>
          TimeSpan.FromDays(value);

    }
}
