using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberDecoratorLib;

namespace NumberDecoratorTester
{
    /// <summary>
    /// Summary description for NumberDecoratorLibTester
    /// </summary>
    [TestClass]
    public class NumberDecoratorLibTester
    {
        public NumberDecoratorLibTester()
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

        //Validates that the returned list non-null
        [TestMethod]
        public void TestNonNull()
        {
            try
            {
                List<string> list = NumberDecorator.getNumberedList(1, 15, new FizzBuzzMapper());
                Assert.IsNotNull(list);
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception: " + ex.Message);
            }
        }

        //Validates that the length of the returned list is as expected
        [TestMethod]
        public void TestLength()
        {
            try
            {
                List<string> list = NumberDecorator.getNumberedList(1, 15, new FizzBuzzMapper());
                Assert.IsTrue(list.Count == 15);
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception: " + ex.Message);
            }
        }

        //Validates that the exception is correctly thrown for an invalid mapper
        [TestMethod]
        public void TestInvalidMapper()
        {
            try
            {
                List<string> list = NumberDecorator.getNumberedList(1, 100, null);

                Assert.Fail("Exception should have been thrown for invalid mapper");
            }
            catch (ArgumentException)
            {
                //Good.
            }
            catch (Exception ex)
            {
                //Another kind of exception should not happen
                Assert.Fail("Unexpected exception: " + ex.Message);
            }
        }

        //Validates that the exception is correctly thrown for an invalid range
        [TestMethod]
        public void TestInvalidRange()
        {
            try
            {
                List<string> list = NumberDecorator.getNumberedList(100, 1, new FizzBuzzMapper());

                Assert.Fail("Exception should have been thrown for invalid range");
            }
            catch (ArgumentException )
            {
                //Good.
            }
            catch (Exception ex)
            {
                //Another kind of exception should not happen
                Assert.Fail("Unexpected exception: " + ex.Message);
            }
        }

        //Validates that returned list has proper values for the FizzBuzzMapper
        //built into the library
        [TestMethod]
        public void TestCorrectFizzBuzz()
        {
            try
            {
                List<string> expected = new List<string>() {"1", "2", "fizz", "4", "buzz", "fizz",
                                                            "7", "8", "fizz", "buzz", "11", "fizz",
                                                            "13", "14", "fizzbuzz"};
                List<string> list = NumberDecorator.getNumberedList(1, 15, new FizzBuzzMapper());
                CollectionAssert.AreEqual(expected, list);
            }
            catch (Exception ex)
            {
                //Another kind of exception should not happen
                Assert.Fail("Unexpected exception: " + ex.Message);
            }
        }


    
    }
}
