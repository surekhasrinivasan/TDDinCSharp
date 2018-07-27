using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsComponentNameSpace;

namespace MathsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //Testcase todo Addition
        [TestMethod]
        public void TestMethod1()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }
    }
}
