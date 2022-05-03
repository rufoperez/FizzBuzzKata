using FizzBuzzKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKataTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void when_topnumber_is_1_then_return_1()
        {
            string result = FizzBuzzPrinter.Print(1);

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void when_topnumber_is_2_then_return_1_2()
        {
            string result = FizzBuzzPrinter.Print(2);

            Assert.AreEqual("1 2", result);
        }

        [TestMethod]
        public void when_topnumber_is_3_then_return_1_2_fizz()
        {
            string result = FizzBuzzPrinter.Print(3);

            Assert.AreEqual("1 2 fizz", result);
        }
    }
}