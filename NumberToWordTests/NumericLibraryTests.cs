using Moq;
using NumberToWord;
using NUnit.Framework;

namespace NumberToWord.Tests
{
    public class NumericLibraryTests
    {
        Mock<INumericLibrary> _lib;
        [SetUp]
        public void Setup()
        {
            _lib = new Mock<INumericLibrary>();
        }

        [Test]
        public void NumberTestSuccess()
        {
            string result = _lib.Object.NumberToWord(0);
            Assert.IsNotNull(result);
        }
        [Test]
        public void NumberTestFailure()
        {
            string result = _lib.Object.NumberToWord(0);
            Assert.AreNotSame(result, "");
        }
        [TestCase(35847)]
        public void NumberTestOutputNormal(int n)
        {
            string result = _lib.Object.NumberToWord(n);
            Assert.AreEqual("Thirty Five Thousands Eight Hundred Fourty Seven", result);
        }
        [TestCase(0)]
        public void NumberTestOutputZero(int n)
        {
            string result = _lib.Object.NumberToWord(n);
            Assert.AreEqual("Zero", result);
        }
    }
}
