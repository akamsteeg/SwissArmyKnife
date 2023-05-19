using System;

namespace SwissArmyKnife
{
    /// <summary>
    /// Extension methods for <see cref="IComparable{T}"/>
    /// </summary>
    public static class IComparableExtensions
    {
        #region IsBetween()

        /// <summary>
        /// Checks whether the object is equal to or between the supplied lower
        /// and upper values
        /// </summary>
        /// <param name="value">
        /// </param>
        /// <param name="lower">
        /// The lower bound
        /// </param>
        /// <param name="upper">
        /// The upper bound
        /// </param>
        /// <returns>
        /// True if the value is between or equal to the lower or upper value,
        /// false otherwise
        /// </returns>
        public static bool IsBetween<T>(this T value, T lower, T upper) where T : IComparable<T> =>
            value.CompareTo(lower) >= 0 && value.CompareTo(upper) <= 0;

        #endregion

        #region IsLessThan()

        /// <summary>
        /// Checks whether the object is less than the supplied value
        /// </summary>
        /// <param name="value">
        /// </param>
        /// <param name="valueToCompareWith">
        /// The lower bound
        /// </param>
        /// <returns>
        /// True if the value is less than the supplied value; false otherwise
        /// </returns>
        public static bool IsLessThan<T>(this T value, T valueToCompareWith) where T : IComparable<T> =>
            value.CompareTo(valueToCompareWith) < 0;

        #endregion

        #region IsLargerThan()

        /// <summary>
        /// Checks whether the object is larger than the supplied value
        /// </summary>
        /// <param name="value">
        /// </param>
        /// <param name="valueToCompareWith">
        /// The lower bound
        /// </param>
        /// <returns>
        /// True if the value is larger than the supplied value; false otherwise
        /// </returns>
        public static bool IsGreaterThan<T>(this T value, T valueToCompareWith) where T : IComparable<T> =>
            value.CompareTo(valueToCompareWith) > 0;

        #endregion
    }
}
