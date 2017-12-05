using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            input = string.Concat(input.Split(' '));

            int odd = int.Parse(Console.ReadLine());
            int even = int.Parse(Console.ReadLine());
            string oddLetters = "";
            string totalOdds = "";
            string totalEvens = "";
            string evenLetters = "";
            long result = 0;
            long result2 = 0;
            string odds = "";
            string evens = "";

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (i % 2 == 0)
                {
                    oddLetters += current;
                    totalOdds = oddLetters;
                }
                else
                {
                    evenLetters += current;
                    totalEvens = evenLetters;
                }
            }
            for (int j = 0; j < totalOdds.Length; j++)
            {
                char currentChar = totalOdds[j];
                if (j == (odd - 1) || ((j + 1) % odd == 0))
                {
                    result *= currentChar;
                }
                else
                {
                    result += currentChar;
                }
            }


            for (int k = 0; k < totalEvens.Length; k++)
            {
                char currentChar = totalEvens[k];
                if (k == (even - 1) || ((k + 1) % even == 0))
                {
                    result2 *= currentChar;
                }
                else
                {
                    result2 += currentChar;
                }
            }
            odds = result.ToString("X");
            evens = result2.ToString("X");

            Console.WriteLine("Odd: {0}", odds);
            Console.WriteLine("Even: {0}", evens);

        }
    }
}
