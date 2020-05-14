using NUnit.Framework;

namespace NumberToWord.Tests
{
    public class NumericLibraryTests
    {
        NumericLibrary _lib;
        [SetUp]
        public void Setup()
        {
            _lib = new NumericLibrary();
        }

        [Test]
        public void NumberTestSuccess()
        {
            string result = _lib.SpellNumber(1);
            Assert.IsNotNull(result);
        }
        [Test]
        public void NumberTestFailure()
        {
            string result = _lib.SpellNumber(1);
            Assert.AreNotSame(result, "");
        }
        [TestCase(86)]
        public void NumberTestOutputNormal(int n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Eighty Six ", result);
        }
        [TestCase(13456)]
        public void NumberTestOutputNormalBig(int n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Thirteen Thousand Four Hundred Fifty Six ", result);
        }
    }
}
