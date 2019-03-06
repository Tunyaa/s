using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using newtours.Web;

namespace newtours.Tests
{
    
    [TestFixture]

    class TestPages
    {
        TestsInp test = new TestsInp();
        [Test]
        public void Test1(String str)
        {
            String s = "Find a Flight: Mercury Tours:";
           // Assert.AreEqual(s, str);
            Assert.Equals(s, str);
        }

        [Test]
        public void Test2()
        {
            String s = "Find a Flight: Mercury Tours:";
            Assert.AreEqual(s, test.findTitle);
        }
    }
}
