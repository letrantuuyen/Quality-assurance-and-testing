using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodLibrary; // Thay thế YourNamespace bằng tên namespace chứa lớp MethodLibrary

namespace UnitTestProject1
{
    [TestClass]
    public class UTLab2
    {
            [TestMethod]
            public void TestSolveQuadratic()
        {
            // Arrange
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            float x1 =1;
            float x2 =4;

            string expextedResult = o.SolveQuadratic(1, -5, 4, out x1, out x2);
            Assert.AreEqual(expextedResult, "Có 2 nghiệm phân biệt");
        }
        [TestMethod]
        public void TestSolveQuadratic2()
        {
            // Arrange
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            float x1 = 2;
            float x2 = 2;

            string expextedResult = o.SolveQuadratic(2, -4, 2, out x1, out x2);
            Assert.AreEqual("Có nghiệm kép",expextedResult);
        }
        [TestMethod]
        public void TestSolveQuadratic3()
        {
            // Arrange
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            float x1 ;
            float x2 ;

            string expextedResult = o.SolveQuadratic(5, 4, 3, out x1, out x2);
            Assert.AreEqual("Vô nghiệm", expextedResult);
        }
        [TestMethod]
        public void TestSolveQuadratic4()
        {
            // Arrange
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            float x1 ;
            float x2 ;

            string expextedResult = o.SolveQuadratic(0, 0, 0, out x1, out x2);
            Assert.AreEqual("Vô số nghiệm", expextedResult);
        }
    }
    
}
