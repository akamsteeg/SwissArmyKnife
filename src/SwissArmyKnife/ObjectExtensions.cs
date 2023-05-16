using System.Collections.Generic;

namespace SwissArmyKnife
{
    /// <summary>
    /// Generic extension methods
    /// </summary>
    public static class ObjectExtensions
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
        /// <param name="value2">The third value to check the object against</param>
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
        /// <param name="value2">The third value to check the object against</param>
        /// <param name="value3">The fourth value to check the object against</param>
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
            IsAnyOfInternal(source, values);

        /// <summary>
        /// Checks if the object is equal to any of the supplied values
        /// </summary>
        /// <param name="source"></param>
        /// <param name="values">The values to check the object against</param>
        /// <returns>True if the object is equal to any of the values, false otherwise</returns>
        public static bool IsAnyOf<T>(this T source, IEnumerable<T> values) =>
            IsAnyOfInternal(source, values);

        /// <summary>
        /// Checks if the object is equal to any of the supplied values
        /// </summary>
        /// <param name="source">The current object to compare the values against</param>
        /// <param name="values">The values to check the object against</param>
        /// <returns>True if the object is equal to any of the values, false otherwise</returns>
        private static bool IsAnyOfInternal<T>(T source, IEnumerable<T> values)
        {
            var result = false;

            foreach (var currentValue in values)
            {
                result = source.Equals(currentValue);

                if (result)
                    break;
            }

            return result;
        }

        #endregion

        #region IsEqualToAll()

        /// <summary>
        /// Checks if the object is equal to the supplied value
        /// </summary>
        /// <param name="source">The current object to compare the values against</param>
        /// <param name="value">The values to check the object against</param>
        /// <returns>True if the object is equal to the supplied value, false otherwise</returns>

        public static bool IsEqualToAll<T>(this T source, T value) =>
            source.Equals(value);

        /// <summary>
        /// Checks if the object is equal to all the supplied values
        /// </summary>
        /// <param name="source">The current object to compare the values against</param>
        /// <param name="value0">The first value to check the object against</param>
        /// <param name="value1">The second value to check the object against</param>
        /// <returns>True if the object is equal to all of the supplied values, false otherwise</returns>
        public static bool IsEqualToAll<T>(this T source, T value0, T value1) =>
            source.Equals(value0)
            && source.Equals(value1);

        /// <summary>
        /// Checks if the object is equal to all the supplied values
        /// </summary>
        /// <param name="source">The current object to compare the values against</param>
        /// <param name="value0">The first value to check the object against</param>
        /// <param name="value1">The second value to check the object against</param>
        /// <param name="value2">The third value to check the object against</param>
        /// <returns>True if the object is equal to all of the supplied values, false otherwise</returns>
        public static bool IsEqualToAll<T>(this T source, T value0, T value1, T value2) =>
            source.Equals(value0)
            && source.Equals(value1)
            && source.Equals(value2);

        /// <summary>
        /// Checks if the object is equal to all the supplied values
        /// </summary>
        /// <param name="source">The current object to compare the values against</param>
        /// <param name="value0">The first value to check the object against</param>
        /// <param name="value1">The second value to check the object against</param>
        /// <param name="value2">The third value to check the object against</param>
        /// <param name="value3">The fourth value to check the object against</param>
        /// <returns>True if the object is equal to all of the supplied values, false otherwise</returns>
        public static bool IsEqualToAll<T>(this T source, T value0, T value1, T value2, T value3) =>
            source.Equals(value0)
            && source.Equals(value1)
            && source.Equals(value2)
            && source.Equals(value3);


        /// <summary>
        /// Checks if the object is equal to all the supplied values
        /// </summary>
        /// <param name="source">The current object to compare the values against</param>
        /// <param name="values">The values to check the object against</param>
        /// <returns>True if the object is equal to all of the supplied values, false otherwise</returns>
        public static bool IsEqualToAll<T>(this T source, params T[] values) =>
            IsEqualToAllInternal(source, values);

        /// <summary>
        /// Checks if the object is equal to all the supplied values
        /// </summary>
        /// <param name="source">The current object to compare the values against</param>
        /// <param name="values">The values to check the object against</param>
        /// <returns>True if the object is equal to all of the supplied values, false otherwise</returns>
        public static bool IsEqualToAll<T>(this T source, IEnumerable<T> values) =>
            IsEqualToAllInternal(source, values);

        /// <summary>
        /// Checks if the object is equal to all the supplied values
        /// </summary>
        /// <param name="source">The current object to compare the values against</param>
        /// <param name="values">The values to check the object against</param>
        /// <returns>True if the object is equal to all of the supplied values, false otherwise</returns>
        private static bool IsEqualToAllInternal<T>(this T source, IEnumerable<T> values)
        {
            var result = true;

            foreach (var currentValue in values)
            {
                if (!source.Equals(currentValue))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        #endregion
    }
}
