using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UTLab6
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string ActualResult = o.ThayThe("Truong dh cong nghiep", "dh", "dai hoc");

            Assert.AreEqual( "Truong dai hoc cong nghiep", ActualResult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string ActualResult = o.ThayThe("", "", "");

            Assert.AreEqual( "", ActualResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string ActualResult = o.ThayThe("Truong dh cong nghiep", "", "dai hoc");

            Assert.AreEqual( "Truong dh cong nghiep", ActualResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string ActualResult = o.ThayThe("Truong dh cong nghiep", "cn", "dai hoc");

            Assert.AreEqual( "Truong dh cong nghiep", ActualResult);
        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string ActualResult = o.ThayThe("Truong dh cong nghiep","dh", "");

            Assert.AreEqual("Truong  cong nghiep", ActualResult);
        }
    }
}
