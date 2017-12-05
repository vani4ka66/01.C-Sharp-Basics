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
            bool print = false;
            string input = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int numbersOfElements = 0;
            string lastNumber = numbers[0];
            int count = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (lastNumber == numbers[i])
                {
                    count++;
                }
                else
                {
                    numbersOfElements = count;
                    if (count >= k)
                    {
                        numbersOfElements = count % k;
                    }
                    for (int j = 0; j < numbersOfElements; j++)
                    {
                        Console.Write(" " + lastNumber);
                    }
                    count = 1;
                }
                lastNumber = numbers[i];
            }
            numbersOfElements = count;
            if (count >= k)
            {
                numbersOfElements = count % k;
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write(" " + lastNumber);
            }
        }
    }

}
   
