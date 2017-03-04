using System;
using System.Collections.Generic;

namespace MixedPhones
{
    public class MixedPhones
    {
        public static void Main()
        {
            var phones = new SortedDictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "Over")
            {
                var parts = input.Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var n = 0m;

                bool isNumeric = decimal.TryParse(parts[0], out n);
                if (isNumeric)
                {
                    parts[0] = parts[1];
                    parts[1] = n.ToString();
                    phones.Add(parts[0], parts[1]);
                }
                else
                {
                    phones.Add(parts[0], parts[1]);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in phones)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
