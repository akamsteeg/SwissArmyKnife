using System;

namespace SwissArmyKnife.Helpers
{
    /// <summary>
    /// Represents a helper for equality comparisons
    /// </summary>
    public static class EqualityHelper
    {
        /// <summary>
        /// Determines whether the specified object is equal to the current object
        /// based on the hash code
        /// </summary>
        /// <typeparam name="T">
        /// The <see cref="Type"/> of the current object
        /// </typeparam>
        /// <param name="current">
        /// The object to compare with the other object
        /// </param>
        /// <param name="other">
        /// The object to compare with the current object
        /// </param>
        /// <returns>
        /// True if the specified object is equal to the current object; false otherwise
        /// </returns>
        public static bool Equals<T>(T current, object other)
          where T : notnull
        {
            var result = (other is not null and T otherT && current.GetHashCode() == otherT.GetHashCode());

            return result;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the
        /// same type based on the hash code
        /// </summary>
        /// <typeparam name="T">
        /// The <see cref="Type"/> of the current  and other object
        /// </typeparam>
        /// <param name="current">
        /// The object to compare with the other object
        /// </param>
        /// <param name="other">
        /// An object to compare with the current object
        /// </param>
        /// <returns>
        /// True if the current object is equal to the other parameter; false otherwise
        /// </returns>
        public static bool Equals<T>(T current, T other)
          where T : notnull
        {
            var result = (other is not null && current.GetHashCode() == other.GetHashCode());

            return result;
        }
    }
}
