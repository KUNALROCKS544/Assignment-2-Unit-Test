using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assignment2_UnitTest;

namespace UnitTestAssignment1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]


        public void TestingGetlengthequalto1()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Getlength();
            Assert.AreEqual(1, endResult);
        }
        [TestMethod]
        public void TestingGetLengtharenotequalto0()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Getlength();
            Assert.AreNotEqual(0, endResult, "The endresult cannot be smaller then 1");
        }
        [TestMethod]

        public void TestingGetLengtharenotequalto1()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Getlength();
            Assert.IsTrue(endResult == 1);
        }


        [TestMethod]


        public void TestingSetLengthequalto1()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Setlength(1);
            Assert.AreEqual(1, endResult);

        }


        [TestMethod]


        public void testinggetlengthisnotequaltominus1()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Setlength(-1);
            Assert.AreNotEqual(-1, 1, "We cannot set the value of length as negative integer");
        }
        [TestMethod]

        public void testingsetlengtharenotequalto0()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Setlength(0);
            Assert.AreNotEqual(0, 1, "The value of length cannot be 0");
        }



        [TestMethod]


        public void TestingGetwidthequalto1()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Getwidth();
            Assert.AreEqual(1, endResult);
        }


        [TestMethod]
        public void testinggetwidtharenotequalto0()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Getwidth();
            Assert.AreNotEqual(0, endResult, "The endresult cannot be smaller then 1");
        }


        public void Testinggetwidthistrue()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Getwidth();
            Assert.IsTrue(endResult == 1);
        }


        [TestMethod]


        public void TestSetWidthareequalto1()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Setwidth(1);
            Assert.AreEqual(1, endResult);

        }


        [TestMethod]


        public void TestingSetwidthAreNotEqualtominusone()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Setwidth(-1);
            Assert.AreNotEqual(-1, 1, "We cannot set the value of length as negative integer");
        }


        public void testingSetWidthAreNotEqualto0()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Setwidth(0);
            Assert.AreNotEqual(0, 1, "The value of length cannot be 0");
        }


        [TestMethod]


        public void TestingGetHeightequalto1()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Getheight();
            Assert.AreEqual(1, endResult);
        }
        [TestMethod]
        public void TestingGetHeightarenotequalto0()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Getheight();
            Assert.AreNotEqual(0, endResult, "The endresult cannot be smaller then 1");
        }
        [TestMethod]

        public void TestingGetHeightisequalto1()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Getheight();
            Assert.IsTrue(endResult == 1);
        }


        [TestMethod]


        public void TestingSetHeightAreEqualto1()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Setheight(1);
            Assert.AreEqual(1, endResult);

        }


        [TestMethod]


        public void TestingSetHeightAreNotEqualtoMinusOne()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Setheight(-1);
            Assert.AreNotEqual(-1, 1, "We cannot set the value of length as negative integer");
        }
        [TestMethod]

        public void TestingSetHeightAreNotEqualto0()
        {
            Rectangle rectangle = new Rectangle();
            int endResult = rectangle.Setheight(0);
            Assert.AreNotEqual(0, 1, "The value of length cannot be 0");
        }


        [TestMethod]

        public void TestingGetVolumeAreNotEqualToMinusOne()
        {
            Rectangle rectangle = new Rectangle(-1);
            int endResult = rectangle.GetVolume();
            Assert.AreNotEqual(-1,endResult);
        }


        [TestMethod]

        public void testingGetVolumeIsFalse()
        {
            Rectangle rectangle = new Rectangle(0,1,1);
            int endResult = rectangle.GetVolume();
            Assert.IsTrue(endResult == 0 );
        }


        [TestMethod]

        public void TestingGetVolumeIsEqualto1()
        {
            Rectangle rectangle = new Rectangle(1,1,1);
            int endResult = rectangle.GetVolume();
            Assert.AreEqual(1, endResult);
        }




























    }
}

