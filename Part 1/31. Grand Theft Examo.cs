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

            int slapped;
            int totalSlaped = 0;
            int escaped = 0;
            int drinkBeers = 0;
            int packs = 0;
            int remainBeer = 0;

            for (int i = 0; i < n; i++)
            {
                int thievesInside = int.Parse(Console.ReadLine());
                int beers = int.Parse(Console.ReadLine());
                if (thievesInside >= 5)
                {
                    slapped = 5;
                }
                else
                {
                    slapped = thievesInside;
                }

                escaped += (thievesInside - slapped);

                totalSlaped = n * slapped;
                drinkBeers += beers;

                for (int j = 1; j <= drinkBeers; j++)
                {
                    packs = drinkBeers / 6;
                    remainBeer = drinkBeers % 6;
                }
            }

            Console.WriteLine("{0} thieves slapped.", totalSlaped);
            Console.WriteLine("{0} thieves escaped.", escaped);
            Console.WriteLine("{0} packs, {1} bottles.", packs, remainBeer);


        }
    }
}
