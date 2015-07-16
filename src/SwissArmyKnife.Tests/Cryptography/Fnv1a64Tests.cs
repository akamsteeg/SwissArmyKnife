using NUnit.Framework;
using SwissArmyKnife.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Tests.Cryptography
{
    [TestFixture]
    internal class Fnv1a64Tests : Fnv1aTestsBase
    {
        public Fnv1a64Tests()
            : base(new Fnv1a64())
        {

        }

        [Test, Sequential, Explicit("Need to fix the cast exceptions first")]
        public void Fnv_Succesful(
            [Values("fnv", "Fowler/Noll/Vo", "fowler", "noll", "vo")]string input,
            [Values(15903756304948927129, 15903756304948927129, 15903756304948927129, 15903756304948927129, 15903756304948927129)]uint expected
            )
        {
            var hashedData = this.GetHashResult(input);

            ulong result = BitConverter.ToUInt64(hashedData, 0);

            Assert.AreEqual(expected, result);
        }
    }
}
