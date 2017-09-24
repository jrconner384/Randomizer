using System;
using System.Text;
using Randomizer.Infrastructure;

namespace Randomizer
{
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
    }
}
