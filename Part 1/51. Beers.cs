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
            string input = Console.ReadLine();

            int countStacks = 0;
            int countBeers = 0;


            while (input != "End")
            {
                string[] command = input.Split(' ');
                string one = command[0];
                int oneInt = int.Parse(one);
                string two = command[1];


                if (two == "stacks")
                {
                    countBeers += oneInt * 20;
                }
                else
                {
                    countBeers += oneInt;
                }
                if (countBeers > 20)
                {


                }

                input = Console.ReadLine();

            }
            Console.WriteLine("{0} stacks + {1} beers", countBeers / 20, countBeers % 20);

        }

    }
}

