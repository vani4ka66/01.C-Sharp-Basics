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

            for (int i = 0; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', (n - 2 * i)));
            }
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', (n - 2 * i)));

            }

        }
    }
}
