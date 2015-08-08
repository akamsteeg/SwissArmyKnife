using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwissArmyKnife.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="IComparable{T}"/>
    /// </summary>
    public static class IComparableExtensions
    {
        #region IsBetween()

        /// <summary>
        /// Checks whether the object is between the supplied upper and lower values
        /// </summary>
        /// <param name="value"></param>
        /// <param name="lower">The lower bound</param>
        /// <param name="upper">The upper bound</param>
        /// <returns>True if the value is between or equal to the lower or upper value, false otherwise</returns>
        public static bool IsBetween<T>(this T value, T lower, T upper) where T : IComparable<T> =>
            (value.CompareTo(lower) >= 0 && value.CompareTo(upper) <= 0);

        #endregion
    }
}
