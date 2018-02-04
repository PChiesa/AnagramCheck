using System;
using AnagramCheck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramCheckTests
{
    [TestClass]
    public class AnagramValidationTests
    {
        private AnagramValidation anagramValidation;


        [TestInitialize]
        public void Init()
        {
            anagramValidation = new AnagramValidation();
        }

        [TestMethod]
        public void ShouldBeAnagram()
        {
            bool result = anagramValidation.IsAnagram("ROTA", "ATOR");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotBeAnagramSameWordLength()
        {
            bool result = anagramValidation.IsAnagram("PEDRA", "ATRIZ");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldNotBeAnagramDifferentWordLength()
        {
            bool result = anagramValidation.IsAnagram("ROTA", "ATRIZ");
            Assert.IsFalse(result);
        }

    }
}
