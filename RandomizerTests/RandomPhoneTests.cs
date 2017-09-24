using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Randomizer;

namespace RandomizerTests
{
    [TestClass]
    public class RandomPhoneTests
    {
        private const int sampleSize = 10000;

        private static readonly Regex naPhone = new Regex(@"^[(]\d\d\d[)]\d\d\d[-]\d\d\d\d$");

        private static readonly Regex naPhonePlusCountry = new Regex(@"^[+][1][(]\d\d\d[)]\d\d\d[-]\d\d\d\d$");

        [TestMethod]
        public void NorthAmerica_IsFormattedWithoutCountryCode_WhenNoArgumentIsPassed()
        {
            for (int i = 0; i < sampleSize; i++)
            {
                string phone = RandomPhone.NorthAmerica();
                StringAssert.Matches(phone, naPhone, "The randomized phone number does not match the (xxx)xxx-xxxx format where `x` is any digit.");
            }
        }

        [TestMethod]
        public void NorthAmerica_IsFormattedWithCountryCode_WhenPassedTrue()
        {
            for (int i = 0; i < sampleSize; i++)
            {
                string phone = RandomPhone.NorthAmerica(true);
                StringAssert.Matches(phone, naPhonePlusCountry, "The randomized phone number does not match the +1(xxx)xxx-xxxx format where `x` is any digit.");
            }
        }
    }
}
