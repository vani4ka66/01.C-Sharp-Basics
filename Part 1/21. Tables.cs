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
            long pac1 = long.Parse(Console.ReadLine());
            long pac2 = long.Parse(Console.ReadLine());
            long pac3 = long.Parse(Console.ReadLine());
            long pac4 = long.Parse(Console.ReadLine());
            long topsHave = long.Parse(Console.ReadLine());
            long tablesToBemade = long.Parse(Console.ReadLine());



            long legsHave = (1 * pac1) + (2 * pac2) + (3 * pac3) + (4 * pac4);
            long legsNeed = tablesToBemade * 4;

            long tablesMade = Math.Min((legsHave / 4), topsHave);

            long legsDiff = (legsHave - legsNeed);
            long topsDiff = tablesToBemade - topsHave;

            if (tablesToBemade == tablesMade)
            {
                Console.WriteLine("Just enough tables made: {0}", tablesToBemade);
            }
            else if (tablesToBemade > tablesMade)
            {
                Console.WriteLine("less: {0}", (topsHave - tablesToBemade));
                Console.WriteLine("tops needed: {0}, legs needed: 0", Math.Abs(tablesToBemade - topsHave));
            }
            else
            {
                Console.WriteLine("more: {0}", Math.Abs(tablesToBemade - topsHave));
                Console.WriteLine("tops left: {0}, legs left: {1}", Math.Abs(tablesToBemade - topsHave), (legsDiff));
            }



        }
    }
}
