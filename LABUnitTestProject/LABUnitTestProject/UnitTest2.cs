using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasslibrary;
using System;

namespace LABUnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_Assignment()
        {
            Assignment ac = new Assignment();
            int input = 20;
            string result = ac.greadCalculate(input);
            Assert.AreEqual("F", result);

            //result = ac.greadCalculate(-1);
            //Assert.AreEqual("F", result);
        }
        [TestMethod]
        public void Test_Assignment_2()
        {
            Assignment ac = new Assignment();
            double result = ac.getDistance(3, 2, 7, 8);
            Assert.AreEqual(7.21, result);
            result = ac.getDistance(-3, 2, 7, -8);
            Assert.AreEqual(14.14, result);
            result = ac.getDistance(-3, -2, -7, -8);
            Assert.AreEqual(7.21, result);
            result = ac.getDistance(3, -2, -7, 8);
            Assert.AreEqual(14.14, result);
        }
        [TestMethod]
        public void Test_Assignment_3()
        {
            Assignment ac = new Assignment();
            int result = ac.getFactorial(4);
            Assert.AreEqual(24, result);
        }
        [TestMethod]
        public void Test_AssignmentClass_4()
        {

            Assignment ac = new Assignment();
            string Password = "nattcatt";
            bool password = ac.checkPassword(Password);
            Assert.AreEqual(true, password);
        }
    }
}
