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
    }
}