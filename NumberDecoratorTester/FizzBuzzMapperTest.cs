using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberDecoratorLib;

namespace NumberDecoratorTester
{
    /// <summary>
    /// Summary description for FizzBuzzMapperTest
    /// </summary>
    [TestClass]
    public class FizzBuzzMapperTest
    {
        public FizzBuzzMapperTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        //Testing that various inputs for the FizzBuzzMapper provide expected output
        [TestMethod]
        public void TestFizzBuzzMapper3()
        {
            var mapper = new FizzBuzzMapper();
            string result = mapper.getStringRepresentationForNumber(3);
            Assert.AreEqual(result, "fizz");
        }

        [TestMethod]
        public void TestFizzBuzzMapper5()
        {
            var mapper = new FizzBuzzMapper();
            string result = mapper.getStringRepresentationForNumber(5);
            Assert.AreEqual(result, "buzz");
        }

        [TestMethod]
        public void TestFizzBuzzMapper15()
        {
            var mapper = new FizzBuzzMapper();
            string result = mapper.getStringRepresentationForNumber(15);
            Assert.AreEqual(result, "fizzbuzz");
        }

        [TestMethod]
        public void TestFizzBuzzMapper1()
        {
            var mapper = new FizzBuzzMapper();
            string result = mapper.getStringRepresentationForNumber(1);
            Assert.AreEqual(result, "1");
        }
    }
}
