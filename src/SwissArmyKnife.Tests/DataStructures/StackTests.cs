using NUnit.Framework;
using SwissArmyKnife.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Tests.DataStructures
{
    [TestFixture]
    internal class StackTests
    {
        [Test]
        public void PushAndPopOneItem_Successful()
        {
            const int item = 0;

            var s = new Stack();

            s.Push(item);
            var t1 = s.Pop();

            Assert.IsNotNull(t1);
            Assert.AreEqual(item, t1);
        }

        [Test]
        public void PushTwoAndPopOneItem_Successful()
        {
            var s = new Stack();

            s.Push("first");
            s.Push("second");
            var t1 = s.Pop();

            Assert.IsNotNull(t1);
            Assert.AreEqual("second", t1);
        }

        [Test]
        public void PushTwoAndPopTwoItems_Successful()
        {
            var s = new Stack();

            s.Push("first");
            s.Push("second");
            var t1 = s.Pop();
            var t2 = s.Pop();

            Assert.IsNotNull(t1);
            Assert.AreEqual("second", t1);

            Assert.IsNotNull(t2);
            Assert.AreEqual("first", t2);
        }

        [Test]
        public void PushAndPopMany_Successful()
        {
            const int size = 10000;

            var s = new Stack();

            for (int i = 0; i < size; i++)
            {
                s.Push(i);
            }

            for (int i = size-1; i > 0; i--)
            {
                var t1 = s.Pop();

                Assert.IsNotNull(t1);
                Assert.AreEqual(i, t1);
            }
        }

        [Test]
        public void PopPastTheEndGivesNull_Successful()
        {
            var s = new Stack();

            s.Push(1);

            var t1 = s.Pop();
            var t2 = s.Pop();

            Assert.IsNotNull(t1);
            Assert.AreEqual(1, t1);

            Assert.IsNull(t2);
        }

        [Test]
        public void PopFromEmptyStack_Successful()
        {
            var s = new Stack();

            var t1 = s.Pop();

            Assert.IsNull(t1);
        }
    }
}
