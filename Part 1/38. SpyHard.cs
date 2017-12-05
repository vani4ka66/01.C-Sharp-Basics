using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLetter = int.Parse(Console.ReadLine());
            string input = Console.ReadLine().ToLower();
            int length = input.Length;
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar >= 'a' && currentChar <= 'z')
                {
                    sum += currentChar - 'a' + 1;
                }
                else
                {
                    sum += currentChar;

                }
            }

            string converted = string.Empty;
            long rest;
            while (sum > 0)
            {
                rest = sum % firstLetter;
                sum /= firstLetter;

                converted = rest.ToString() + converted;

            }
            converted = (firstLetter + "" + length + converted);
            Console.WriteLine(converted);

        }
    }
}
