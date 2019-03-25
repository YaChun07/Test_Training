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
    public class Test
    {
        [TestMethod()]
        public void Append01Test()
        {
            var reverseWord = new ReverseWord();
            
            Assert.AreEqual("str01", reverseWord.AppendZeroOne("str"));
        }
    }
}


