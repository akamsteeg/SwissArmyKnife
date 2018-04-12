using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SwissArmyKnife.Tests
{
    [TestFixture]
    public class ObjectExtensionsTests
    {
        #region IsAnyOf()

        [Test]
        public void IsAnyOf_SingleIntSameAsInput_Succeeds()
        {
            1.IsAnyOf(1);
        }

        [Test]
        public void IsAnyOf_SingleIntButDifferentAsInput_Succeeds()
        {
            1.IsAnyOf(2);

        }

        [Test]
        public void IsAnyOf_TwoInts_Succeeds()
        {
            Assert.IsTrue(1.IsAnyOf(2, 1));
        }

        [Test]
        public void IsAnyOf_ThreeInts_Succeeds()
        {
            Assert.IsTrue(1.IsAnyOf(3, 2, 1));
        }

        [Test]
        public void IsAnyOf_FourInts_Succeeds()
        {
            Assert.IsTrue(1.IsAnyOf(4, 3, 2, 1));
        }

        [Test]
        public void IsAnyOf_ManyInts_Succeeds()
        {
            Assert.IsTrue(1.IsAnyOf(9, 8, 7, 6, 5, 4, 3, 2, 1));
        }

        #endregion
    }
}
