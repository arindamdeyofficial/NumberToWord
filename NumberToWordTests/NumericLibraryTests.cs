using NUnit.Framework;
using System;

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
        public void NumberTestOutputNormal(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Eighty Six", result);
        }
        [TestCase(14)]
        public void NumberTestOutputTeen(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Fourteen", result);
        }
        [TestCase(20)]
        public void NumberTestOutputTwenty(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Twenty", result);
        }
        [TestCase(21)]
        public void NumberTestOutputTwentyOne(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Twenty One", result);
        }
        [TestCase(40)]
        public void NumberTestOutputDecade(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Fourty", result);
        }
        [TestCase(99)]
        public void NumberTestOutputNinetyNine(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Ninety Nine", result);
        }
        [TestCase(100)]
        public void NumberTestOutputHundredBasic(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Hundred", result);
        }
        [TestCase(101)]
        public void NumberTestOutputHundredNormal(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Hundred One", result);
        }
        [TestCase(110)]
        public void NumberTestOutputHundredDecadeOne(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Hundred Ten", result);
        }
        [TestCase(140)]
        public void NumberTestOutputHundredDecadeFour(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Hundred Fourty", result);
        }
        [TestCase(199)]
        public void NumberTestOutputHundredLastBarier(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Hundred Ninety Nine", result);
        }
        [TestCase(200)]
        public void NumberTestOutputHundredTwo(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Two Hundred", result);
        }
        [TestCase(1000)]
        public void NumberTestOutputThousandBasic(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Thousand", result);
        }
        [TestCase(1001)]
        public void NumberTestOutputThousandNormal(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Thousand One", result);
        }
        [TestCase(1010)]
        public void NumberTestOutputThousandDecade(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Thousand Ten", result);
        }
        [TestCase(1099)]
        public void NumberTestOutputThousandHundredBarier(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Thousand Ninety Nine", result);
        }
        [TestCase(1040)]
        public void NumberTestOutputThousandDecadeFour(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Thousand Fourty", result);
        }
        [TestCase(13456)]
        public void NumberTestOutputDualHundred(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Thirteen Thousand Four Hundred Fifty Six", result);
        }
        [TestCase(134565)]
        public void NumberTestOutputLakhBasic(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Lakh Thirty Four Thousand Five Hundred Sixty Five", result);
        }
        [TestCase(1345657)]
        public void NumberTestOutputLakhDual(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Thirteen Lakh Fourty Five Thousand Six Hundred Fifty Seven", result);
        }
        [TestCase(13456574)]
        public void NumberTestOutputCroreBasic(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Crore Thirty Four Lakh Fifty Six Thousand Five Hundred Seventy Four", result);
        }
        [TestCase(13456570)]
        public void NumberTestOutputCroreBasicZero(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Crore Thirty Four Lakh Fifty Six Thousand Five Hundred Seventy", result);
        }
        [TestCase(134568745)]
        public void NumberTestOutputNormalCroreDual(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Thirteen Crore Fourty Five Lakh Sixty Eight Thousand Seven Hundred Fourty Five", result);
        }
        //Capacity Check
        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

        [TestCase(65535)]
        //ushort int Unsigned 16-bit short integer || capacity 0 to 65,535
        public void NumberTestOutputUshort(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Sixty Five Thousand Five Hundred Thirty Five", result);
        }

        [TestCase(127)]
        //sbyte int Signed 8-bit integer || capacity -128 to 127
        //System.SByte
        public void NumberTestOutputSByte(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("One Hundred Twenty Seven", result);
        }

        [TestCase(255)]
        //byte int Unsigned 8-bit integer || capacity 0 to 255
        //System.Byte
        public void NumberTestOutputByte(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Two Hundred Fifty Five", result);
        }
        [TestCase(32767)]
        //short int Signed 16-bit integer || capacity -32,768 to 32,767
        //System.Int16
        public void NumberTestOutputShort(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Thirty Two Thousand Seven Hundred Sixty Seven", result);
        }
        [TestCase(2147483647)]
        //normal int || capacity -2,147,483,648 to 2,147,483,647
        //214 Crore
        public void NumberTestOutputNormalInt(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Two Hundred Fourteen Crore Seventy Four Lakh Eighty Three Thousand Six Hundred Fourty Seven", result);
        }
        [TestCase(4294967295)]
        //uint Unsigned 32-bit long integer || capacity 0 to 4,294,967,295
        //System.UInt32
        //429 Crore
        public void NumberTestOutputunsignedlongInt(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Four Hundred Twenty Nine Crore Fourty Nine Lakh Sixty Seven Thousand Two Hundred Ninety Five", result);
        }

        [TestCase(9223372036854775807)]
        //long int || max capacity -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        //System.Int64
        //92233 Crore
        public void NumberTestOutputVeryBig(Int64 n)
        {
            string result = _lib.SpellNumber(n);
            Assert.AreEqual("Ninety Two Thousand Two Hundred Thirty Three Crore Seventy Two Lakh Three Thousand Six Hundred Eighty Five Crore Fourty Seven Lakh Seventy Five Thousand Eight Hundred Seven", result);
        }

        //UInt64 not supported
        //[TestCase(18446744073709551615)]
        ////ulong Unsigned 64-bit integer || capacity 0 to 18,446,744,073,709,551,615
        ////System.UInt64
        ////1844674407370 Crore
        //public void NumberTestOutputunsignedlong(Int64 n)
        //{
        //    string result = _lib.SpellNumber(n);
        //    Assert.AreEqual("Two Hundred Fourteen Crore Seventy Four Lakh Eighty Three Thousand Six Hundred Fourty Seven", result);
        //}
    }
}
