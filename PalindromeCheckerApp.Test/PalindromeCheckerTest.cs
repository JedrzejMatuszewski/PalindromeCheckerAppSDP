using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeCheckerApp.Test
{
    [TestFixture]
    class PalindromeCheckerTest
    {

        [TestCase("aaaaa", true)]
        [TestCase("abccba", true)]
        [TestCase("kajak", true)]
        public void PalindromeChecker_WithSimplePalindromeStrings_ReturnTrue(string value, bool expectedValue)
        {
            var result = PalindromeChecker.Check(value);

            Assert.AreEqual(expectedValue, result);
        }


        [TestCase("aaaab", false)]
        [TestCase("abacba", false)]
        [TestCase("kajaa", false)]
        public void PalindromeChecker_WithSimpleNonPalindromeStrings_ReturnFalse(string value, bool expectedValue)
        {
            var result = PalindromeChecker.Check(value);

            Assert.AreEqual(expectedValue, result);
        }


        [TestCase("kobyla ma maly bok", true)]
        [TestCase("a    tu mam    mamuta", true)]
        [TestCase("     zakopane        na      pokaz   ", true)]
        public void PalindromeChecker_WithPalindromeStringsWithWhiteSymbols_ReturnTrue(string value, bool expectedValue)
        {
            var result = PalindromeChecker.Check(value);

            Assert.AreEqual(expectedValue, result);
        }


        [TestCase("kobyla nie ma maly bok", false)]
        [TestCase("a    tu mam    mammmuta", false)]
        [TestCase("     zakopane    nie    na      pokaz   ", false)]
        public void PalindromeChecker_WithNonPalindromeStringsWithWhiteSymbols_ReturnFalse(string value, bool expectedValue)
        {
            var result = PalindromeChecker.Check(value);

            Assert.AreEqual(expectedValue, result);
        }


        [TestCase("a", false)]
        [TestCase("B", false)]
        [TestCase("1", false)]
        public void PalindromeChecker_WithStringShorterThanTwoChars_ReturnFalse(string value, bool expectedValue)
        {
            var result = PalindromeChecker.Check(value);

            Assert.AreEqual(expectedValue, result);
        }


        // PalindromeChecker.Check function is case sensitive
        [TestCase("ccAaBaAcc", true)]
        [TestCase("KAJAK", true)]
        [TestCase("ZakoPane na PokaZ", true)]
        [TestCase("Kobyla        Ma      Maly boK", true)]
        public void PalindromeChecker_WithPalindomsContainsUpperCaseLetters_ReturnTrue(string value, bool expectedValue)
        {
            var result = PalindromeChecker.Check(value);

            Assert.AreEqual(expectedValue, result);
        }


        // PalindromeChecker.Check function is case sensitive
        [TestCase("ccAaBaAcC", false)]
        [TestCase("KAJAk", false)]
        [TestCase("ZakoPane na Pokaz", false)]
        [TestCase("Kobyla        Ma      Maly bok", false)]
        public void PalindromeChecker_WithNonPalindomsContainsUpperCaseLetters_ReturnFalse(string value, bool expectedValue)
        {
            var result = PalindromeChecker.Check(value);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
