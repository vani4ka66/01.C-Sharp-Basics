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
            string leap = Console.ReadLine();
            int contract = int.Parse(Console.ReadLine());
            int family = int.Parse(Console.ReadLine());

            int normalMonths = 12 - contract - family;

            int contractTravels = (4 * 3) * contract;

            int familyTravels = 2 * 2 * family;

            double normalTravels = ((normalMonths * 12) * 3 / 5.0);

            double totalTravels = contractTravels + familyTravels + normalTravels;


            if (leap == "leap")
            {
                totalTravels = totalTravels * 1.05;
            }

            Console.WriteLine((int)totalTravels);

        }
    }
}
