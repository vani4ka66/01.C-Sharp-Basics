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
            int h = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            int x5 = int.Parse(Console.ReadLine());
            int y5 = int.Parse(Console.ReadLine());

            if (((x1 >= h) && (x1 <= (h * 2))
                && (y1 >= h) && (y1 <= h * 4))
                || (((x1 >= 0) && (x1 <= (h * 3))
                && (y1 >= 0) && (y1 <= h))))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }


        }
    }
}
