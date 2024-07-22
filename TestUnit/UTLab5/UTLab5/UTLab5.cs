using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UTLab5
{
    [TestClass]
    public class UTLab5
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string s = "xin chao";
            int n = 20;
            int p = 3;
            string actual = o.HuyChuoi(s, n, p);
            string expected = "xin";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string s = "xin chao";
            int n = 3;
            int p = 20;
            string actual = o.HuyChuoi(s, n, p);
            string expected = "xin chao";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string s = "xin chao";
            int n = -1;
            int p = -1;
            string actual = o.HuyChuoi(s, n, p);
            string expected = "xin chao";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string s = "    ";
            int n = 3;
            int p = 5;
            string actual = o.HuyChuoi(s, n, p);
            string expected = "    ";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string s = "x";
            int n = 0;
            int p = 0;
            string actual = o.HuyChuoi(s, n, p);
            string expected = "x";
            Assert.AreEqual(expected, actual);
        }

    }
}
