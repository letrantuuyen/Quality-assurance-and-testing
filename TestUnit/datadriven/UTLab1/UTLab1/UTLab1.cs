using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUnit
{
    [TestClass]
    public class UTLab1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\UTLab1TestDate.csv", "UTLab1TestDate#csv", DataAccessMethod.Sequential),
        DeploymentItem("UTLab1TestDate.csv"), TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = Int32.Parse(TestContext.DataRow[0].ToString());
            int b = Int32.Parse(TestContext.DataRow[1].ToString());
            int c = Int32.Parse(TestContext.DataRow[2].ToString());
            int expected = Int32.Parse(TestContext.DataRow[3].ToString());
            int actual = o.Max(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 10;
            int b = 8;
            int c = 12;
            double actual = o.Max(a, b, c);
            double expect = 12;
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 9;
            int b = 10;
            int c = 8;
            double actual = o.Max(a, b, c);
            double expect = 10;
            Assert.AreEqual(expect, actual);

        }
        [TestMethod]
        public void TestMethod4()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                int a = -5;
                int b = 9;
                int c = 8;
                double actual = o.Max(a, b, c);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }

            Assert.IsNotNull(expectedResult);

        }

        [TestMethod]
        public void TestMethod5()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                int a = 60;
                int b = 9;
                int c = 9;
                double actual = o.Max(a, b, c);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }

            Assert.IsNotNull(expectedResult);

        }

        [TestMethod]
        public void TestMethod6()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                int a = 9;
                int b = -8;
                int c = 7;
                double actual = o.Max(a, b, c);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }

            Assert.IsNotNull(expectedResult);

        }

        [TestMethod]
        public void TestMethod7()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                int a = 10;
                int b = 60;
                int c = 2;
                double actual = o.Max(a, b, c);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }

            Assert.IsNotNull(expectedResult);

        }

        [TestMethod]
        public void TestMethod8()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                int a = 9;
                int b = 8;
                int c = -5;
                double actual = o.Max(a, b, c);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }

            Assert.IsNotNull(expectedResult);

        }

        [TestMethod]
        public void TestMethod9()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                int a = 9;
                int b = 8;
                int c = 60;
                double actual = o.Max(a, b, c);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }

            Assert.IsNotNull(expectedResult);

        }

        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 1;
            int b = 1;
            int c = 1;
            double actual = o.Max(a, b, c);
            double expect = 1;
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = 50;
            int b = 50;
            int c = 50;
            double actual = o.Max(a, b, c);
            double expect = 50;
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void TestMethod12()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                int a = 0;
                int b = 9;
                int c = 10;
                double actual = o.Max(a, b, c);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }

            Assert.IsNotNull(expectedResult);

        }

        [TestMethod]
        public void TestMethod13()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                int a = 9;
                int b = 0;
                int c = 10;
                double actual = o.Max(a, b, c);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }

            Assert.IsNotNull(expectedResult);

        }

        [TestMethod]
        public void TestMethod14()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                int a = 9;
                int b = 10;
                int c = 0;
                double actual = o.Max(a, b, c);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }

            Assert.IsNotNull(expectedResult);

        }

    }
}