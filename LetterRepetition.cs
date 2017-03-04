using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterRepetition
{
    public class LetterRepetition
    {
        public static void Main()
        {
            var letters = Console.ReadLine()
               .ToArray();

            var result = new Dictionary<char, int>();

            foreach (var letter in letters)
            {
                if (!result.ContainsKey(letter))
                {
                    result[letter] = 0;
                }
                result[letter]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
