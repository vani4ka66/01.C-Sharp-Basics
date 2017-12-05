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
            string n = "73167176531330624919225119674426574742355349194934"; //"1111110";
            int max = int.MinValue;

            for (int i = 0; i < n.Length; i++)
            {
                if (i >= (n.Length - 5))
                {
                    break;
                }

                int current = n[i] - '0';
                int current1 = n[i + 1] - '0';
                int current2 = n[i + 2] - '0';
                int current3 = n[i + 3] - '0';
                int current4 = n[i + 4] - '0';
                int current5 = n[i + 5] - '0';

                int product = 0;

                if (i <= (n.Length - 5))
                {
                    product = current * current1 * current2 * current3 * current4 * current5;
                }

                if (max < product)
                {
                    max = product;
                }

            }

            Console.WriteLine(max);

        }
    }
}
