﻿using SwissArmyKnife.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Tests.Cryptography
{
    internal abstract class Fnv1aTestsBase
    {
        protected Fnv1aBase FnvHash
        {
            get;
            private set;
        }

        public Fnv1aTestsBase(Fnv1aBase fnvHash)
        {
            this.FnvHash = fnvHash;
        }

        protected byte[] GetHashResult(string input)
        {
            byte[] dataToHash = Encoding.UTF8.GetBytes(input);
            byte[] hashedData = this.FnvHash.ComputeHash(dataToHash);

            return hashedData;
        }
    }
}
