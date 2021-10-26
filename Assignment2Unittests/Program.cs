using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2_UnitTest;

namespace Assignment2Unittests
{
    [TestFixture]
    class Program
    {
        public void TestCase1()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Getlength();
            Assert.AreEqual(1, endResult);
        }


    }
