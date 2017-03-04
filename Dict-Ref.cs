using System;
using System.Collections.Generic;

namespace Dict_Ref
{
    public class Program
    {
        public static void Main()
        {
            var list = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var parts = input.Split(" =".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int n = 0;
                bool isNumeric = int.TryParse(parts[1], out n);
                if (isNumeric)
                {
                    if (list.ContainsKey(parts[0]))
                    {
                        list[parts[0]] = parts[1];
                    }
                    else
                    {
                        list.Add(parts[0], parts[1]);
                    }
                }  
                else
                {                    
                    if (list.ContainsKey(parts[1]))
                    {
                        list[parts[0]] = list[parts[1]];
                    }
                               
                }           

                input = Console.ReadLine();
            }

            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
