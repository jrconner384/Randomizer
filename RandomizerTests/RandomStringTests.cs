using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Randomizer;
using Randomizer.Infrastructure;

namespace RandomizerTests
{
    [TestClass]
    public class RandomStringTests
    {
        private const int sampleSize = 10000;

        private static readonly Regex alphanumeric = new Regex(@"^[a-zA-Z0-9]*$");

        [TestMethod]
        public void OfLength_int_CreatesStringOfCorrectLength()
        {
            for (int i = 0; i < sampleSize; i++)
            {
                string rand = RandomString.OfLength(i);
                Assert.AreEqual(i, rand.Length, "The randomized string did not contain the expected number of characters.");
            }
        }

        [TestMethod]
        public void OfLength_int_UsesUsAlphanmericOnly()
        {
            for (int i = 1; i < sampleSize; i++)
            {
                string rand = RandomString.OfLength(i);
                StringAssert.Matches(rand, alphanumeric);
            }
        }

        [TestMethod]
        public void OfLength_intChararr_CreatesStringOfCorrectLength()
        {
            for (int i = 0; i < sampleSize; i++)
            {
                string brackets = RandomString.OfLength(i, CharacterSets.BRACKETS);
                string lowers = RandomString.OfLength(i, CharacterSets.US_LOWER);
                string uppers = RandomString.OfLength(i, CharacterSets.US_UPPER);
                string alpha = RandomString.OfLength(i, CharacterSets.US_ALPHA);
                string alphaNum = RandomString.OfLength(i, CharacterSets.US_ALPHANUMERIC);
                string punctuation = RandomString.OfLength(i, CharacterSets.PUNCTUATION);

                Assert.AreEqual(i, brackets.Length, "The randomized brackets string did not contain the expected number of characters.");
                Assert.AreEqual(i, lowers.Length, "The randomized lower letters string did not contain the expected number of characters.");
                Assert.AreEqual(i, uppers.Length, "The randomized upper letters string did not contain the expected number of characters.");
                Assert.AreEqual(i, alpha.Length, "The randomized alpha string did not contain the expected number of characters.");
                Assert.AreEqual(i, alphaNum.Length, "The randomized alphanumeric string did not contain the expected number of characters.");
                Assert.AreEqual(i, punctuation.Length, "The randomized punctuation string did not contain the expected number of characters.");
            }
        }
    }
}
