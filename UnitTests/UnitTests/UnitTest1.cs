using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using triangle;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 12, b = 4, c = 5;
            double s = RightTr.Area(a,b,c);
        }
    }
}
