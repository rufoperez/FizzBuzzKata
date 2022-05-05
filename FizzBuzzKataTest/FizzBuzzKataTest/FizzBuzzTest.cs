using FizzBuzzKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKataTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void when_number_is_1_then_return_1()
        {
            string result = FizzBuzzPrinter.Print(1);

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void when_number_is_2_then_return_2()
        {
            string result = FizzBuzzPrinter.Print(2);

            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void when_number_is_3_then_return_fizz()
        {
            string result = FizzBuzzPrinter.Print(3);

            Assert.AreEqual("fizz", result);
        }

        [TestMethod]
        public void when_number_is_4_then_return_4()
        {
            string result = FizzBuzzPrinter.Print(4);

            Assert.AreEqual("4", result);
        }

        [TestMethod]
        public void when_number_is_5_then_return_buzz()
        {
            string result = FizzBuzzPrinter.Print(5);

            Assert.AreEqual("buzz", result);
        }

        [TestMethod]
        public void when_number_is_6_then_return_fizz()
        {
            string result = FizzBuzzPrinter.Print(6);

            Assert.AreEqual("fizz", result);
        }

        [TestMethod]
        public void when_number_is_7_then_return_7()
        {
            string result = FizzBuzzPrinter.Print(7);

            Assert.AreEqual("7", result);
        }

        [TestMethod]
        public void when_number_is_9_then_return_fizz()
        {
            string result = FizzBuzzPrinter.Print(9);

            Assert.AreEqual("fizz", result);
        }

        [TestMethod]
        public void when_number_is_10_then_return_buzz()
        {
            string result = FizzBuzzPrinter.Print(10);

            Assert.AreEqual("buzz", result);
        }

        [TestMethod]
        public void when_number_is_12_then_return_fizz()
        {
            string result = FizzBuzzPrinter.Print(12);

            Assert.AreEqual("fizz", result);
        }
    }
}