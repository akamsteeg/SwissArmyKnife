﻿using System.Collections.Generic;
using System.IO;
using Xunit;

namespace SwissArmyKnife.Tests
{
    public class ObjectExtensionsTests
    {
        #region IsAnyOf()

        [Fact]
        public void StringIsAnyOfSingleValue_Successful()
        {
            var t1 = "test".IsAnyOf<string>("test");
            var t2 = "test".IsAnyOf<string>("not test");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsAnyOfTwoValues_Successful()
        {
            var t1 = "test".IsAnyOf<string>("test", "fake");
            var t2 = "test".IsAnyOf<string>("not test", "fake");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsAnyOfThreeValues_Successful()
        {
            var t1 = "test".IsAnyOf<string>("test", "fake0", "fake1");
            var t2 = "test".IsAnyOf<string>("not test", "fake0", "fake1");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsAnyOfFourValues_Successful()
        {
            var t1 = "test".IsAnyOf<string>("test", "fake0", "fake1", "fake2");
            var t2 = "test".IsAnyOf<string>("not test", "fake0", "fake1", "fake2");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsAnyOfManyValues_Successful()
        {
            var t1 = "test".IsAnyOf<string>("test", "fake0", "fake1", "fake2", "fake3");
            var t2 = "test".IsAnyOf<string>("not test", "fake0", "fake1", "fake2", "fake3");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsAnyOfSingleValue_Successful()
        {
            var t1 = 1.IsAnyOf(1);
            var t2 = 1.IsAnyOf(2);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsAnyOfTwoValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2);
            var t2 = 1.IsAnyOf(2, 3);

            Assert.True(t1);
            Assert.False(t2);
        }
        [Fact]
        public void IntIsAnyOfThreeValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2, 3);
            var t2 = 1.IsAnyOf(-1, 2, 3);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsAnyOfFourValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2, 3, 4);
            var t2 = 1.IsAnyOf(-1, 2, 3, 4);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsAnyOfManyValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2, 3, 4, 5);
            var t2 = 1.IsAnyOf(-1, 2, 3, 4, 6);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void EnumIsAnyOfManyValues_Successful()
        {
            var t1 = FileMode.Open.IsAnyOf(FileMode.Append, FileMode.Open);
            var t2 = FileMode.Open.IsAnyOf(FileMode.Append, FileMode.Create);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void EnumIsAnyOfArray_Successful()
        {
            var t1 = FileMode.Open.IsAnyOf(new[] { FileMode.Append, FileMode.Open });
            var t2 = FileMode.Open.IsAnyOf(new[] { FileMode.Append, FileMode.Create });

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void EnumIsAnyOfIEnumerable_Successful()
        {
            var t1 = FileMode.Open.IsAnyOf(new List<FileMode>() { FileMode.Append, FileMode.Open });
            var t2 = FileMode.Open.IsAnyOf(new List<FileMode>() { FileMode.Append, FileMode.Create });

            Assert.True(t1);
            Assert.False(t2);
        }

        #endregion

        #region IsEqualToAll()

        [Fact]
        public void StringIsEqualToAllValue_Successful()
        {
            var t1 = "test".IsEqualToAll("test");
            var t2 = "test".IsEqualToAll("not test");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsEqualToAllTwoValues_Successful()
        {
            var t1 = "test".IsEqualToAll("test", "test");
            var t2 = "test".IsEqualToAll("test", "fake");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsEqualToAllThreeValues_Successful()
        {
            var t1 = "test".IsEqualToAll("test", "test", "test");
            var t2 = "test".IsEqualToAll("test", "fake0", "fake1");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsEqualToAllFourValues_Successful()
        {
            var t1 = "test".IsEqualToAll("test", "test", "test", "test");
            var t2 = "test".IsEqualToAll("test", "fake0", "fake1", "fake2");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsEqualToAllManyValues_Successful()
        {
            var t1 = "test".IsEqualToAll("test", "test", "test", "test", "test");
            var t2 = "test".IsEqualToAll("test", "fake0", "fake1", "fake2", "fake3");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsEqualToAllSingleValue_Successful()
        {
            var t1 = 1.IsEqualToAll(1);
            var t2 = 1.IsEqualToAll(2);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsEqualToAllTwoValues_Successful()
        {
            var t1 = 1.IsEqualToAll(1, 1);
            var t2 = 1.IsEqualToAll(1, 2);

            Assert.True(t1);
            Assert.False(t2);
        }
        [Fact]
        public void IntIsEqualToAllThreeValues_Successful()
        {
            var t1 = 1.IsEqualToAll(1, 1, 1);
            var t2 = 1.IsEqualToAll(1, 2, 3);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsEqualToAllFourValues_Successful()
        {
            var t1 = 1.IsEqualToAll(1, 1, 1, 1);
            var t2 = 1.IsEqualToAll(1, 2, 3, 4);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsEqualToAllManyValues_Successful()
        {
            var t1 = 1.IsEqualToAll(1, 1, 1, 1, 1);
            var t2 = 1.IsEqualToAll(1, 2, 3, 4, 6);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void EnumIsEqualToAllManyValues_Successful()
        {
            var t1 = FileMode.Open.IsEqualToAll(FileMode.Open, FileMode.Open);
            var t2 = FileMode.Open.IsEqualToAll(FileMode.Open, FileMode.Create);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void EnumIsEqualToAllArray_Successful()
        {
            var t1 = FileMode.Open.IsEqualToAll(new[] { FileMode.Open, FileMode.Open });
            var t2 = FileMode.Open.IsEqualToAll(new[] { FileMode.Append, FileMode.Create });

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void EnumIsEqualToAllEnumerable_Successful()
        {
            var t1 = FileMode.Open.IsEqualToAll(new List<FileMode>() { FileMode.Open, FileMode.Open });
            var t2 = FileMode.Open.IsEqualToAll(new List<FileMode>() { FileMode.Append, FileMode.Create });

            Assert.True(t1);
            Assert.False(t2);
        }


        #endregion
    }
}
