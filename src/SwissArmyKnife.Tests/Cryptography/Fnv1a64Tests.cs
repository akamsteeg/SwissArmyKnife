using NUnit.Framework;
using SwissArmyKnife.Cryptography;
using System;

namespace SwissArmyKnife.Tests.Cryptography
{
  [TestFixture]
    internal class Fnv1a64Tests : Fnv1aTestsBase
    {
        public Fnv1a64Tests()
            : base(new Fnv1a64())
        {

        }

        [Test, Sequential]
        public void Fnv_Succesful(
            [Values("fnv", "Fowler/Noll/Vo", "fowler", "noll", "vo")]string input,
            [Values(15903756304948927129UL, 16489909637164264766UL, 12534660946462825874UL, 4329070551024743754UL, 634788777754156882UL)]ulong expected
            )
        {
            var hashedData = this.GetHashResult(input);

            ulong result = BitConverter.ToUInt64(hashedData, 0);

            Assert.AreEqual(expected, result);
        }
    }
}
