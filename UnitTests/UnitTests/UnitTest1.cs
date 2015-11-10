using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using triangle;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StandartArgsTest()
        {
            // trying ok arguments
            double a = 3, b = 4, c = 5;
            double s = RightTr.Area(a,b,c);
        }
        [TestMethod]
        public void BigArgsTest()
        {
            // trying to big arguments
            try
            {
                double a = 12, b = 4, c = 5;
                double s = RightTr.Area(a, b, c);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, "One of the arguments are greater then the sum of others");
            }
        }
        [TestMethod]
        public void WrongArgsTest()
        {
            //trying bellow zero arguments
            try
            {
                double a = -1, b = 4, c = 5;
                double s = RightTr.Area(a, b, c);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "One or many of the arguments are bellow or equals zero");
            }
            
        }
    }
}
