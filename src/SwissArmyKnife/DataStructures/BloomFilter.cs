using SwissArmyKnife.Cryptography;
using System;

namespace SwissArmyKnife.DataStructures
{
    /// <summary>
    /// 
    /// </summary>
    public class BloomFilter
    {
        private const int BitSize = 64;
        private const int NumberOfHashes = 3;

        private readonly bool[] _buckets;

        /// <summary>
        /// Initializes a new instance of <see cref="BloomFilter"/>
        /// </summary>
        /// <param name="size">
        /// The number of buckets
        /// </param>
        public BloomFilter(int size)
        {
            double x = size / BitSize;
            double ceiledCapacity = Math.Ceiling(x);
            var capacity = (uint)ceiledCapacity * BitSize;

            this._buckets = new bool[capacity];
        }

        /// <summary>
        /// Add data to the filter
        /// </summary>
        /// <param name="input">
        /// The data to add
        /// </param>
        public void Add(byte[] input)
        {
            var hashes = GetHashes(input);

            var primaryHash = hashes[0];
            var secondaryHash = hashes[1];

            for (var i = 0; i < NumberOfHashes; i++)
            {
                uint location = (uint)((primaryHash + (i * secondaryHash)) % this._buckets.Length);

                this._buckets[location] = true;
            }
        }

        /// <summary>
        /// Test whether the input is probably
        /// in the filter, or absolutely not
        /// </summary>
        /// <returns>
        /// True if the data is probably in the
        /// filter, false otherwise
        /// </returns>
        public bool Test(byte[] input)
        {
            bool result = true;

            var hashes = GetHashes(input);

            var primaryHash = hashes[0];
            var secondaryHash = hashes[1];

            for (var i = 0; i < NumberOfHashes; i++)
            {
                uint location = (uint)((primaryHash + (i * secondaryHash)) % this._buckets.Length);

                if (this._buckets[location] == false)
                {
                    result = false;
                }
            }

            return result;
        }

        /// <summary>
        /// Get three hash values to determine the 
        /// places in the buckets
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <returns></returns>
        private static uint[] GetHashes(byte[] input)
        {
            var hashResults = new uint[NumberOfHashes - 1];
            using (var fnvHash = new Fnv1a32())
            {
                var hashedDataA = fnvHash.ComputeHash(input);
                uint fnvResultA = BitConverter.ToUInt32(hashedDataA, 0);

                var hashedDataB = fnvHash.ComputeHash(hashedDataA);
                uint fnvResultB = BitConverter.ToUInt32(hashedDataB, 0);

                hashResults[0] = fnvResultA;
                hashResults[1] = fnvResultB;
            }

            return hashResults;
        }
    }
}
