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

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}*{0}", new string('.', ((3 * n) + 1) / 2));

            for (int i = 0; i < ((n / 2) + 1); i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', (((3 * n) / 2)) - i), new string('.', 1 + 2 * i));
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', (n + 2)));

            for (int j = 0; j < n / 2; j++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', 1 + j),
                    new string('.', (((3 * n) - 2)) - (2 * j)));
            }
            Console.WriteLine("{0}*{1}**{2}**{1}*{0}",
                       new string('.', (((n / 2) - 1))),
                       new string('.', n / 2),
                       new string('.', n));
            for (int k = 0; k < (n / 2 - 1); k++)
            {
                Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                    new string('.', (((n / 2) - 2) - k)),
                    new string('.', n / 2),
                    new string('.', 1 + k),
                    new string('.', n));
            }

            Console.WriteLine("{0}{1}*{2}*{1}{0}",
                new string('*', ((n / 2) + 1)),
                new string('.', n / 2),
                new string('.', n));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{0}*{0}", new string('.', n));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n),
                new string('*', (n + 2)));


        }
    }
}
