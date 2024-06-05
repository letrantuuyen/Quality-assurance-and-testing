using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UTLab3
{
    [TestClass]
    public class UTLab3
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 150;
            int chiSoCu = 100;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 81620; 
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 200;
            int chiSoCu = 100;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 165935;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 280;
            int chiSoCu = 100;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 323103;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 380;
            int chiSoCu = 100;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 559691;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 480;
            int chiSoCu = 100;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 829279;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 580;
            int chiSoCu = 100;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 1112001;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod7()
        {
      
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 150;
            int chiSoCu = -5;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = -1;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 150;
            int chiSoCu = 180;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = -1;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 50;
            int chiSoCu = 50;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 0;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 100;
            int chiSoCu = 50;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 81620;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 100;
            int chiSoCu = 49;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 83306.3;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod12()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 200;
            int chiSoCu = 100;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 165935;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod13()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 200;
            int chiSoCu = 99;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 167899.6;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod14()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 300;
            int chiSoCu = 100;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 362395;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod15()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 300;
            int chiSoCu = 99;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 364861.2;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod16()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 400;
            int chiSoCu = 100;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 609015;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod17()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 400;
            int chiSoCu = 99;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 589572.5;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod18()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 500;
            int chiSoCu = 100;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 862149.2;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod19()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoMoi = 500;
            int chiSoCu = 99;
            double actual = o.TinhTienDien(chiSoCu, chiSoMoi);
            double expect = 864994.9;
            Assert.AreEqual(expect, actual);
        }

 


    }
}
