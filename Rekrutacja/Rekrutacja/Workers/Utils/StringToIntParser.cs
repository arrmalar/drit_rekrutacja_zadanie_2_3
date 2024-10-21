using System;

namespace Rekrutacja.Workers.Utils
{
    public static class StringToIntParser
    {
        public static int ParseToInt(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Wartość nie może być pustym napisem!");
            }

            var isNegative = false;
            var result = 0;
            var startIndex = 0;

            if (input[0] == '-')
            {
                isNegative = true;
                startIndex = 1;
            }

            for (var i = startIndex; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar < '0' || currentChar > '9')
                {
                    throw new ArgumentException($"Liczba składa się z nieprawidłowego znaku '{currentChar}'!");
                }

                result = result * 10 + (currentChar - '0');
            }

            return isNegative ? -result : result;
        }
    }
}
