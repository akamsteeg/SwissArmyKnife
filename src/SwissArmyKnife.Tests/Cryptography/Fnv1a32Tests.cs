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
    internal class Fnv1a32Tests : Fnv1aTestsBase
    {
        public Fnv1a32Tests()
            : base(new Fnv1a32())
        {

        }

        [Test, Sequential]
        public void Fnv_Succesful(
            [Values("fnv", "Fowler/Noll/Vo", "fowler", "noll", "vo")]string input,
            [Values((uint)3002452889, (uint)2281434366, (uint)261441234, (uint)2293073354, (uint)1112130898)]uint expected
            )
        {
            var hashedData = this.GetHashResult(input);

            uint result = BitConverter.ToUInt32(hashedData, 0);

            Assert.AreEqual(expected, result);
        }
    }
}
