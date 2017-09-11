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
            string firstLine = new string('*', n * 2);
            string emptyString = new string(' ', n);
            Console.WriteLine("{0}{1}{0}", firstLine, emptyString);

            string naklonenaCherta = new string('/', ((n - 1) * 2));
            string pravaChertaCherta = new string('|', (n));

            string second = new string('/', ((n - 1) * 2));

            for (int i = 0; i < ((n - 2) / 2); i++)
            {
                Console.WriteLine("*{0}*{1}*{0}*", naklonenaCherta, emptyString);
            }
            Console.WriteLine("*{0}*{1}*{0}*", naklonenaCherta, pravaChertaCherta);

            for (int j = 0; j < ((n - 2) / 2); j++)
            {
                Console.WriteLine("*{0}*{1}*{0}*", naklonenaCherta, emptyString);

            }
            Console.WriteLine("{0}{1}{0}", firstLine, emptyString);

        }
    }
}
