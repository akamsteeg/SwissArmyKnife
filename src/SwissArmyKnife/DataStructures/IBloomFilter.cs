namespace SwissArmyKnife.DataStructures
{
    /// <summary>
    /// Represents a Bloom filter data structure
    /// </summary>
    public interface IBloomFilter
    {
        /// <summary>
        /// Add data to the filter
        /// </summary>
        /// <param name="input">
        /// The data to add
        /// </param>
        void Add(byte[] input);

        /// <summary>
        /// Test whether the input is probably
        /// in the filter, or absolutely not
        /// </summary>
        /// <returns>
        /// True if the data is probably in the
        /// filter, false otherwise
        /// </returns>
        bool Test(byte[] input);
    }
}