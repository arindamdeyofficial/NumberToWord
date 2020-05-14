using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NumberToWord;
using NUnit.Framework;

namespace NumberToWord.Tests
{
    [TestClass()]
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
    }
}
