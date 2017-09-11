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

            Console.WriteLine("{0}{1}{0}",
                new string('.', n),
                new string('*', n));

            for (int i = 0; i < ((n / 2) - 1); i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', n - 1 - i),
                   new string('.', n + 2 * i));
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1),
               new string('.', ((n * 2) - 2)));

            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("*{0}*", new string('.', 3 * n - 2));
            }
            Console.WriteLine("{0}", new string('*', 3 * n));

            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
                    new string('.', n / 2),
                    new string('.', n / 2 - 1),
                    new string('.', n - 2));
            }
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', n / 2),
                new string('*', (n / 2 - 1) + 2),
                new string('.', n - 2));

        }
    }
}
