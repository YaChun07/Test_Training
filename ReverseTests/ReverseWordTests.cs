using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Reverse.Tests
{
    [TestClass()]
    public class ReverseWordTests
    {
        [TestMethod()]
        public void Input_Empty_Should_Return_01()
        {
            var reverseWord = new ReverseWord();

            var actual = reverseWord.AppendZeroOne("");

            Assert.AreEqual("01", actual);
        }

        [TestMethod()]
        public void Input_One_Should_Return_101()
        {
            var reverseWord = new ReverseWord();

            var actual = reverseWord.AppendZeroOne("1");

            Assert.AreEqual("101", actual);
        }
    }
}


