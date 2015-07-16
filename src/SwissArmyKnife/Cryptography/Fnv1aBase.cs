using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SwissArmyKnife.Cryptography
{
    /// <summary>
    /// An base class for Fowler-Noll-Vo 1a implementations
    /// </summary>
    /// <remarks>
    /// FNV is not intended to be a cryptographically safe
    /// hash function
    /// </remarks>
    public abstract class Fnv1aBase : HashAlgorithm
    {
        private ulong _offsetBasis;
        private ulong _fnvPrime;
        private ulong _hashData;

        /// <summary>
        /// Initializes a new instance of <see cref="Fnv1aBase"/>
        /// </summary>
        /// <param name="offsetBasis">
        /// The offset basis for the Fowler-Noll-Vo
        /// algorithm
        /// </param>
        /// <param name="fnvPrime">
        /// The prime to use in the Fowler-Noll-Vo
        /// algorithm
        /// </param>
        internal Fnv1aBase(ulong offsetBasis, ulong fnvPrime)
        {
            this._offsetBasis = offsetBasis;
            this._fnvPrime = fnvPrime;
        }

        /// <summary>
        /// Routes data written to the object into the hash 
        /// algorithm for computing the hash
        /// </summary>
        /// <param name="array">
        /// The input to compute the hash code for
        /// </param>
        /// <param name="ibStart">
        /// The offset into the byte array from which to begin 
        /// using data
        /// </param>
        /// <param name="cbSize">
        /// The number of bytes in the byte array to use as 
        /// data
        /// </param>
        protected sealed override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            this._hashData = this._offsetBasis;

            for (var i = ibStart; i < cbSize; i++)
            {
                unchecked
                {
                    this._hashData ^= array[i];
                    this._hashData *= this._fnvPrime;
                }
            }
        }

        /// <summary>
        /// Finalizes the hash computation after the last data 
        /// is processed by the cryptographic stream object
        /// </summary>
        /// <returns>
        /// The computed hash code
        /// </returns>
        protected sealed override byte[] HashFinal()
        {
            var result = BitConverter.GetBytes(this._hashData);

            return result;
        }

        /// <summary>
        /// Initializes this implementation
        /// of the <see cref="HashAlgorithm"/>
        /// class
        /// </summary>
        public sealed override void Initialize()
        {
        }
    }
}