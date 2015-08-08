using System;

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
        public static bool IsAnyOf<T>(this T source, params T[] values)
        {
            bool result = false;
            
            for (int i = 0; i < values.Length; i++)
            {
                result = source.Equals(values[i]);

                if (result)
                    break;
            }

            return result;
        }

        #endregion
    }
}
