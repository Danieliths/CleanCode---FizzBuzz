using BuzzFeed;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void RunTest()
        {
            using (StringWriter sw = new StringWriter()) 
            {
                FizzBuzz fizzBuzz = new FizzBuzz();
                var test = sw.GetStringBuilder();
            }
            
        }
        [TestMethod]
        public void CheckInputTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual(5, fizzBuzz.CheckInput("5"));
            Assert.AreEqual(0, fizzBuzz.CheckInput("k"));
            Assert.AreEqual(0, fizzBuzz.CheckInput("305"));
            Assert.AreEqual(0, fizzBuzz.CheckInput("-1"));
            Assert.AreEqual(0, fizzBuzz.CheckInput("0"));
            Assert.AreEqual(42, fizzBuzz.CheckInput("42"));
            Assert.AreEqual(90, fizzBuzz.CheckInput("90"));
        }
        [TestMethod]
        public void PrintFizzbuzzTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            for (int i = 1; i <= 300; i++)
            {
                var text = fizzBuzz.GetFizzBuzzString(i);
                if (i == 42)
                {
                    Assert.AreEqual("Answer to the Ultimate Question of Life, the Universe, and Everything", text);
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Assert.AreEqual("Fizzbuzz", text);
                }
                else if (i % 5 == 0)
                {
                    Assert.AreEqual("Buzz", text);
                }
                else if (i % 3 == 0)
                {
                    Assert.AreEqual("Fizz", text);
                }
                else
                {
                    Assert.AreEqual(i.ToString(), text);
                }
            }
        }
    }
}
