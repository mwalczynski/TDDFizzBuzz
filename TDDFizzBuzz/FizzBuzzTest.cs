using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void When_minus210_Then_minusFizzBuzzBuzzinga()
        {
            var number = -210;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("-FizzBuzzBuzzinga", result);
        }

        [TestMethod]
        public void When_minus1_Then_minus1()
        {
            var number = -1;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("-1", result);
        }

        [TestMethod]
        public void When_0_Then_0()
        {
            var number = 0;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void When_1_Then_1()
        {
            var number = 1;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void When_3_Then_Fizz()
        {
            var number = 3;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void When_5_Then_Buzz()
        {
            var number = 5;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void When_7_Then_7()
        {
            var number = 7;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("Buzzinga", result);
        }

        [TestMethod]
        public void When_13_Then_Fizz()
        {
            var number = 13;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void When_15_Then_FizzBuzz()
        {
            var number = 15;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void When_21_Then_FizzBuzzinga()
        {
            var number = 21;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("FizzBuzzinga", result);
        }

        [TestMethod]
        public void When_35_Then_FizzBuzzBuzzinga()
        {
            var number = 35;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("FizzBuzzBuzzinga", result);
        }

        [TestMethod]
        public void When_56_Then_Buzz()
        {
            var number = 56;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("BuzzBuzzinga", result);
        }

        [TestMethod]
        public void When_59_Then_Buzz()
        {
            var number = 59;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void When_1023_Then_Fizz()
        {
            var number = 1023;
            var result = FizzBuzz.Parse(number);
            Assert.AreEqual("Fizz", result);
        }
    }

    public class FizzBuzz
    {
        public static string Parse(int number)
        {
            var result = "";

            if (number < 0)
            {
                result += "-";
            }
            if (number.ToString().Contains("3") || number % 3 == 0)
            {
                result += "Fizz";
            }
            if (number.ToString().Contains("5") || number % 5 == 0)
            {
                result += "Buzz";
            }
            if (number % 7 == 0)
            {
                result += "Buzzinga";
            }
            if (result.Length < 2)
            {
                result = number.ToString();
            }
            if (number == 0)
            {
                result = "0";
            }

            return result;
        }
    }
}
