using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SwissArmyKnife.Cryptography
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Fnv1aBase : HashAlgorithm
    {
        private ulong _offsetBasis;
        private ulong _fnvPrime;
        private ulong _hashData;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="offsetBasis"></param>
        /// <param name="fnvPrime"></param>
        internal Fnv1aBase(ulong offsetBasis, ulong fnvPrime)
        {
            this._offsetBasis = offsetBasis;
            this._fnvPrime = fnvPrime;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="ibStart"></param>
        /// <param name="cbSize"></param>
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
        /// 
        /// </summary>
        /// <returns></returns>
        protected sealed override byte[] HashFinal()
        {
            var result = BitConverter.GetBytes(this._hashData);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        public sealed override void Initialize()
        {
        }
    }
}
}
