using System;
using System.Linq;

namespace SwissArmyKnife.Extensions
{
    /// <summary> 
    /// Generic extension methods
    /// </summary>
    public static class GenericExtensions
    {
        #region IsAnyOf()

        /// <summary>
        /// Checks if the object is equal to the supplied value
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value">The value to check the object against</param>
        /// <returns>True if the object is equal to the value, false otherwise</returns>
        public static bool IsAnyOf<T>(this T source, T value) =>
            source.Equals(value);

        /// <summary>
        /// Checks if the object is equal to the supplied values
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value0">The first value to check the object against</param>
        /// <param name="value1">The second value to check the object against</param>
        /// <returns>True if the object is equal to any of the values, false otherwise</returns>
        public static bool IsAnyOf<T>(this T source, T value0, T value1) =>
            (source.Equals(value0) || source.Equals(value1));

        /// <summary>
        /// Checks if the object is equal to the supplied values
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value0">The first value to check the object against</param>
        /// <param name="value1">The second value to check the object against</param>
        /// <param name="value2">The second value to check the object against</param>
        /// <returns>True if the object is equal to any of the values, false otherwise</returns>
        public static bool IsAnyOf<T>(this T source, T value0, T value1, T value2) =>
            (source.Equals(value0) 
            || source.Equals(value1) 
            || source.Equals(value2));

        /// <summary>
        /// Checks if the object is equal to the supplied values
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value0">The first value to check the object against</param>
        /// <param name="value1">The second value to check the object against</param>
        /// <param name="value2">The second value to check the object against</param>
        /// <param name="value3">The second value to check the object against</param>
        /// <returns>True if the object is equal to any of the values, false otherwise</returns>
        public static bool IsAnyOf<T>(this T source, T value0, T value1, T value2, T value3) =>
            (source.Equals(value0)
            || source.Equals(value1)
            || source.Equals(value2)
            || source.Equals(value3));

        /// <summary>
        /// Checks if the object is equal to any of the supplied values
        /// </summary>
        /// <param name="source"></param>
        /// <param name="values">The values to check the object against</param>
        /// <returns>True if the object is equal to any of the values, false otherwise</returns>
        public static bool IsAnyOf<T>(this T source, params T[] values) =>
            values.Contains(source);

        #endregion

        #region IsBetween()

        /// <summary>
        /// Checks whether the object is between the supplied upper and lower values
        /// </summary>
        /// <param name="value"></param>
        /// <param name="lower">The lower bound</param>
        /// <param name="upper">The upper bound</param>
        /// <returns>True if the value is between or equal to the lower or upper value, false otherwise</returns>
        public static bool IsBetween<T>(this T value, T lower, T upper) where T: IComparable<T> =>
            (value.CompareTo(lower) >= 0 && value.CompareTo(upper) <= 0);

        #endregion
    }
}
