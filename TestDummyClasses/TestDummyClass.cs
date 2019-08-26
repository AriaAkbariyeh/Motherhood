using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestDummyClasses
{
    [TestFixture]
    public class TestDummyClass
    {
        // classic model of assertions
        [Test]
        public void TestClassicAssert()
        {
            // Arrange
            var expected = 1;
            var actual = 1;

            // Act
            // ...

            //Assert
            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void TestConstraintModelAssert()
        {
            // Arrange
            var expected = 1;
            var actual = 1;

            // Act
            // ...

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        //Test reference types equality
        [Test]
        public void TestReferenceTypeAssert()
        {
            // Arrange
            var Oa = new { a = 1 };
            var Ob = new { a = 1 };

            var referenceA = Oa;

            // Act 

            // Assert
            Assert.That(referenceA, Is.SameAs(Oa));

        }



        [Test]
        public void TestDoubleValues()
        {
            double a = 1.0 / 3.0;


            Assert.That(a, Is.EqualTo(0.33).Within(0.004), "This is customr failure message");
        }

        [Test]
        public void TestCollections()
        {
            var aList = new List<string>()
            {
                "hello",
                "world"
            };

            Assert.That(aList, Has.Exactly(2).Items);
            Assert.That(aList, Does.Contain("hello"));
        }



        [Test]
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(2,3)]
        public void MethodLevelTest(int actual, int expected)
        {
            Assert.That(actual, Is.EqualTo(expected));
        }



        [SetUp]
        public void SetUp()
        {
            // Executes before every test
        }


        [TearDown]
        public void TearDown()
        {
            // Executes after every test
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Executes one time before first test
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // Executes one time after the last test
        }


    }


 
    



}
