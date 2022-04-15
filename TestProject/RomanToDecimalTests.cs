using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToDecimal;

namespace TestProject
{
    [TestClass]
    public class RomanToDecimalTests
    {
        [TestMethod]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("VI", 6)]
        [DataRow("XIV", 14)]
        [DataRow("XCIX", 99)]
        public void RomanToDecimal_ValidNumber_ReturnTrue(string input, int expected)
        {
            RomanToDecimalConverter converter = new RomanToDecimalConverter();
            int actual = converter.RomanToDecimal(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
