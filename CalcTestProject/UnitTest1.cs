using Microsoft.VisualStudio.TestTools.UnitTesting;
using quicktestproject;

namespace CalcTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Add()
        {
            Calculator calc = new Calculator();

            var result = calc.Add(2, 2);
            var expected = 4;

            Assert.AreEqual(expected,result);

        }
    }
}
