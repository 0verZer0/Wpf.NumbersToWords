using System;

namespace Zer0.NumbersToWords.Core
{
    public static class NumbersToWordsTranslator
    {
        #region Field
        /// <summary>
        /// Array of all "unit" number words
        /// </summary>
        private readonly static string[] _unitNoWords = new[] { "zero",
                                                             "one",
                                                             "two",
                                                             "three",
                                                             "four",
                                                             "five",
                                                             "six",
                                                             "seven",
                                                             "eight",
                                                             "nine",
                                                             "ten",
                                                             "eleven",
                                                             "twelve",
                                                             "thirteen",
                                                             "fourteen",
                                                             "fifteen",
                                                             "sixteen",
                                                             "seventeen",
                                                             "eighteen",
                                                             "nineteen" };

        /// <summary>
        /// Array of all "ten" number words
        /// </summary>
        private readonly static string[] _tenNoWords = new[] { "zero",
                                                            "ten",
                                                            "twenty",
                                                            "thirty",
                                                            "forty",
                                                            "fifty",
                                                            "sixty",
                                                            "seventy",
                                                            "eighty",
                                                            "ninety" };
        #endregion

        #region Method
        /// <summary>
        /// Converts numbers to words
        /// </summary>
        /// <param name="number">The number value to convert</param>
        /// <returns>Convreted "word" value</returns>
        public static string ToWords(this int number)
        {
            if (number == 0)
                return "zero";
            if (number < 0)
                return $"minus {ToWords(Math.Abs(number))}";

            var words = string.Empty;

            words += ManageTens(ref number, 1000000, "million");
            words += ManageTens(ref number, 1000, "thousand");
            words += ManageTens(ref number, 100, "hundred");

            if (number <= 0)
                return words;
            if (!string.IsNullOrEmpty(words))
                words += "and ";

            if (number < 20)
                words += _unitNoWords[number];
            else
            {
                words += _tenNoWords[number / 10];
                if ((number % 10) > 0)
                    words += $"-{_unitNoWords[number % 10]}";
            }

            return words;
        }
        /// <summary>
        /// Manages "ten" number units
        /// </summary>
        /// <param name="number">The number to manage</param>
        /// <param name="toDivide">The unit to work with</param>
        /// <param name="word">The word to add into "words" collection</param>
        /// <returns>Managed "ten "number unit in words</returns>
        private static string ManageTens(ref int number, int toDivide, string word)
        {
            if ((number / toDivide) > 0)
            {
                var value = $"{ToWords(number / toDivide)} {word} ";
                number %= toDivide;
                return value;
            }

            return string.Empty;
        }
        #endregion
    }
}
