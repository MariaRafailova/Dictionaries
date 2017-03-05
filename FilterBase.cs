using System;
using System.Collections.Generic;

namespace FilterBase
{
    public class FilterBase
    {
        public static void Main()
        {
            var age = new Dictionary<string, int>();
            var salary = new Dictionary<string, double>();
            var position = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "filter base")
            {
                var words = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                int numI = 0;
                bool isInteger = int.TryParse(words[1], out numI);
                double numD = 0;
                bool isDouble = double.TryParse(words[1], out numD);                

                if (isInteger)
                {
                    age.Add(words[0], numI);
                }
                else if (isDouble)
                {
                    salary.Add(words[0], numD);
                }
                else
                {
                    position.Add(words[0], words[1]);
                }

                    input = Console.ReadLine();
            }

            var lastWord = Console.ReadLine();

            if (lastWord == "Age")
            {
                foreach (var kvp in age)
                {
                    Console.WriteLine($"Name: {kvp.Key} \nAge: {kvp.Value} \n====================");
                }
            }
            else if (lastWord == "Salary")
            {
                foreach (var kvp in salary)
                {
                    Console.WriteLine($"Name: {kvp.Key} \nSalary: {kvp.Value:F2} \n====================");
                }
            }
            else
            {
                foreach (var kvp in position)
                {
                    Console.WriteLine($"Name: {kvp.Key} \nPosition: {kvp.Value} \n====================");
                }
            }
   
        }
    }
}
