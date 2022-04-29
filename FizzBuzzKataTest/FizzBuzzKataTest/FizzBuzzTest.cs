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
            string result = FizzBuzzPrinter.Print();

            Assert.AreEqual("1", result);
        }
    }
}