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

            int beers = 0;


            while (input != "End")
            {
                string[] command = input.Split(' ');
                string one = command[0];
                int oneInt = int.Parse(one);
                string two = command[1];


                if (two == "stacks")
                {
                    oneInt *= 20;
                }
                beers += oneInt;

                input = Console.ReadLine();
            }

            Console.WriteLine("{0} stacks + {1} beers", beers / 20, beers % 20);

        }
    }
}
