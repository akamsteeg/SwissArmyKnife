using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwissArmyKnife
{
    public static class GenericExtensions
    {
        public static bool IsAnyOf<T>(this T source, T value) =>
            source.Equals(value);

        public static bool IsAnyOf<T>(this T source, T value1, T value2) =>
            (source.Equals(value1) || source.Equals(value2));

        public static bool IsAnyOf<T>(this T source, T value1, T value2, T value3) =>
            (source.Equals(value1) 
            || source.Equals(value2) 
            || source.Equals(value3));

        public static bool IsAnyOf<T>(this T source, T value1, T value2, T value3, T value4) =>
            (source.Equals(value1)
            || source.Equals(value2)
            || source.Equals(value3)
            || source.Equals(value4));

        /// <summary>
        /// Checks if the object is equal to any of the supplied values
        /// </summary>
        /// <param name="values"></param>
        /// <returns>True if the object is equal to any of the values, false otherwise</returns>
        public static bool IsAnyOf<T>(this T source, params T[] values) =>
            values.Contains(source);
    }
}
