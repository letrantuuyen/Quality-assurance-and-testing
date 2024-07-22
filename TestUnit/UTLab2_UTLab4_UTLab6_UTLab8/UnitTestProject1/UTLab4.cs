using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UTLab4
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long s;

             long k = o.Sum(3, out s);
            Assert.AreEqual(6, s);
                   
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long s;

            long k = o.Sum(-5, out s);
            Assert.AreEqual("lỗi", s);

        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long s;

            long k = o.Sum(0, out s);
            Assert.AreEqual(1, s);

        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long s;

            long k = o.Sum(-1, out s);
            Assert.AreEqual("Lỗi", s);

        }
    }
}
