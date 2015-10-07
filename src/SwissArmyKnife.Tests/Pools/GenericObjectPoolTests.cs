using NUnit.Framework;
using SwissArmyKnife.Pools;
using SwissArmyKnife.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Tests.Pools
{
    [TestFixture]
    public class GenericObjectPoolTests
    {
        [Test]
        public void AddAndGetObjectFromPool_Successful()
        {
            var pool = CreateObjectPool();
            var objectToPool = new IntPoolableObject();

            pool.Add<IntPoolableObject>(objectToPool);

            var objectFromPool = pool.Get<IntPoolableObject>();

            Assert.IsNotNull(objectFromPool);
        }

        [Test]
        public void AddAndTryGetObjectFromPool_Successful()
        {
            var pool = CreateObjectPool();
            var objectToPool = new IntPoolableObject();

            pool.Add<IntPoolableObject>(objectToPool);

            IntPoolableObject objectFromPool;
            var couldRetrieve = pool.TryGet<IntPoolableObject>(out objectFromPool);

            Assert.IsNotNull(objectFromPool);
            Assert.IsTrue(couldRetrieve);
        }

        [Test]
        public void AddGetAndReturnObjectFromPool_Successful()
        {
            var pool = CreateObjectPool();
            var objectToPool = new IntPoolableObject();

            pool.Add<IntPoolableObject>(objectToPool);

            var objectFromPool = pool.Get<IntPoolableObject>();

            Assert.IsNotNull(objectFromPool);

            pool.Return(objectFromPool);
        }

        [Test]
        public void AddGetReturnAndGetObjectFromPool_Successful()
        {
            var pool = CreateObjectPool();
            var objectToPool = new IntPoolableObject();

            pool.Add<IntPoolableObject>(objectToPool);

            var objectFromPool = pool.Get<IntPoolableObject>();
            Assert.IsNotNull(objectFromPool);

            pool.Return(objectFromPool);

            var objectFromPool2 = pool.Get<IntPoolableObject>();
            Assert.IsNotNull(objectFromPool2);
        }

        [Test]
        public void AddOneGetTwoFromPool_Successful()
        {
            var pool = CreateObjectPool();
            var objectToPool = new IntPoolableObject();

            pool.Add<IntPoolableObject>(objectToPool);

            var objectFromPool = pool.Get<IntPoolableObject>();
            Assert.IsNotNull(objectFromPool);

            var objectFromPool2 = pool.Get<IntPoolableObject>();
            Assert.IsNull(objectFromPool2);
        }

        [Test]
        public void GetObjectFromEmptyPool_Successful()
        {
            var pool = CreateObjectPool();

            var objectFromPool = pool.Get<IntPoolableObject>();

            Assert.IsNull(objectFromPool);
        }

        [Test]
        public void AddAndGetMultipleTypesFromPool_Successful()
        {
            var pool = CreateObjectPool();

            var po1 = new IntPoolableObject();
            var po2 = new StringPoolableObject();

            pool.Add(po1);
            pool.Add(po2);

            var retrievedPo1 = pool.Get<IntPoolableObject>();
            var retrievedPo2 = pool.Get<StringPoolableObject>();

            Assert.IsNotNull(retrievedPo1);
            Assert.IsNotNull(retrievedPo2);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNull_Throws()
        {
            var pool = CreateObjectPool();

            IntPoolableObject po1 = null;

            pool.Add(po1);
        }

        private static IObjectPool CreateObjectPool()
        {
            return new GenericObjectPool();
        }
    }
}
