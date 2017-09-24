using System.Linq;

namespace Randomizer.Infrastructure
{
    public static class CharacterSets
    {
        public static readonly char[] US_LOWER =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z' // ASCII 97-122
        };

        public static readonly char[] US_UPPER =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
            'V', 'W', 'X', 'Y', 'Z' // ASCII 65-90
        };

        public static readonly char[] US_ALPHA = US_LOWER.Concat(US_UPPER).ToArray();

        public static readonly char[] DIGITS =
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' // ASCII 48-57
        };

        public static readonly char[] US_ALPHANUMERIC = US_ALPHA.Concat(DIGITS).ToArray();

        public static readonly char[] PUNCTUATION =
        {
            '\'', ':', ',', '-', '!', '(', ')', '.', '?', '"', ';'
        };

        public static readonly char[] BRACKETS =
        {
            '(',')','{','}','[',']','<','>'
        };
    }
}
