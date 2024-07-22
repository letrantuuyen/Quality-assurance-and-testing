using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UTLab7
{
    [TestClass]
    public class UTLab7
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = new int[5];
            a[0] = 9; a[1] = 10;
            a[2] = 11; a[3] = 12;
            a[4] = 13; a[5] = 14;
            int actual = o.Largest(a);
            int expected = a[4];
            Assert.AreEqual(expected, actual);
           
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = new int[0];
            int actual = o.Largest(a);
            int expected = int.MaxValue;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = new int[5];
            a[0] = 9;
            a[1] = 9;
            a[2] = 9;
            a[3] = 9;
            a[4] = 9;
            int actual = o.Largest(a);
            int expected = a[0];
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = new int[1];
            a[0] = 9;
            
            int actual = o.Largest(a);
            int expected = 9;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod5()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
               //  int[-1] a = new int[];
             //   double actual = o.Largest(a);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }

            Assert.IsNotNull(expectedResult);

        }
    }
}
