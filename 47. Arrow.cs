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
	
	            string firstDot = new string('.', n / 2);
	            string firstSharp = new string('#', n);
	            Console.WriteLine("{0}{1}{0}", firstDot, firstSharp);
	
	            string secondDot = new string('.', n - 2);
	            for (int i = 0; i < n - 2; i++)
	            {
	                Console.WriteLine("{0}#{1}#{0}", firstDot, secondDot);
	
	            }
	            string thirdSharp = new string('#', ((n / 2) + 1));
	            Console.WriteLine("{0}{1}{0}", thirdSharp, secondDot);
	
	
	            for (int i = 0; i < n - 2; i++)
	            {
	                Console.WriteLine("{0}#{1}#{0}", new string('.', i + 1), new string('.', ((n * 2 - 5) - 2 * i)));
	            }
	
	
	            Console.WriteLine("{0}#{0}", new string('.', n - 1));

        }
    }
}
