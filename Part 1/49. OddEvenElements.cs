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
            string[] input = Console.ReadLine().Split(' ');

            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;
            double sumOdd = 0;
            double sumEven = 0;

            for (int i = 0; i <= input.Length - 1; i++)
            {
                double currentElement = double.Parse(input[i]);


                if (i % 2 == 0)
                {
                    sumOdd += currentElement; ;
                    if (minOdd > currentElement)
                    {
                        minOdd = currentElement;
                    }
                    if (maxOdd < currentElement)
                    {
                        maxOdd = currentElement;
                    }

                }
                else
                {
                    sumEven += currentElement;
                    if (minEven > currentElement)
                    {
                        minEven = currentElement;
                    }
                    if (maxEven < currentElement)
                    {
                        maxEven = currentElement;
                    }
                }

            }

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
               sumOdd, minOdd, maxOdd, sumEven, minEven, maxEven);

        }
    }
}
