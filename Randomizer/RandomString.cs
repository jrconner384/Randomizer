using System;
using System.Text;
using Randomizer.Infrastructure;

namespace Randomizer
{
    /// <summary>
    /// Randomizes strings according to specified criteria or using some conventional assumptions.
    /// </summary>
    public static class RandomString
    {
        private static readonly Random rand;

        static RandomString()
        {
            rand = new Random();
        }

        /// <summary>
        /// Randomizes a string of the specified <paramref name="length"/> using the <seealso cref="CharacterSets.US_ALPHANUMERIC"/>
        /// character set.
        /// </summary>
        /// <param name="length">The length of the randomized string.</param>
        /// <returns>A randomized string of the specified length using US alphanumeric characters.</returns>
        public static string OfLength(int length)
        {
            return OfLength(length, CharacterSets.US_ALPHANUMERIC);
        }

        /// <summary>
        /// Randomizes a string of the specified <paramref name="length"/>.
        /// </summary>
        /// <param name="length">The length of the randomized string.</param>
        /// <param name="characterSet">The character set to randomize the string from.</param>
        /// <returns>A randomized string of the specified length using the specified character set.</returns>
        /// <remarks>
        /// This method can accept any char array, making the randomization customizable, but you may also select
        /// from predefined character sets in <seealso cref="CharacterSets"/>.
        /// </remarks>
        public static string OfLength(int length, char[] characterSet)
        {
            StringBuilder randomStr = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int r = rand.Next(characterSet.Length - 1);
                randomStr.Append(characterSet[r].ToString());
            }

            return randomStr.ToString();
        }

        /// <summary>
        /// Randomizes a natural number of the specified <paramref name="length"/>.
        /// </summary>
        /// <param name="length">The length of the randomized number.</param>
        /// <returns>A randomized natural number of the specified length.</returns>
        /// <remarks>
        /// Aside from returning a string and not a numerical type, the only functional difference between this and
        /// using something like <seealso cref="Random.Next(int)"/> is that this method can return values with leading
        /// zeroes. Use this, for example, if you want a chance of getting a value like "001" instead of an <c>int</c>
        /// 1.
        /// </remarks>
        public static string NumberOfLength(int length)
        {
            return OfLength(length, CharacterSets.DIGITS);
        }
    }
}
