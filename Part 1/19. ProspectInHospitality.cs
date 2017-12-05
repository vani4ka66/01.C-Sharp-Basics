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

            decimal builderbsSalary = 1500.04m;
            decimal receptionistsSalary = 2102.10m;
            decimal chambermaidsSalary = 1465.46m;
            decimal techniciansSalary = 2053.33m;
            decimal othersSalary = 3010.98m;

            uint b = uint.Parse(Console.ReadLine());
            builderbsSalary *= b;
            uint r = uint.Parse(Console.ReadLine());
            receptionistsSalary *= r;
            uint c = uint.Parse(Console.ReadLine());
            chambermaidsSalary *= c;
            uint t = uint.Parse(Console.ReadLine());
            techniciansSalary *= t;
            uint o = uint.Parse(Console.ReadLine());
            othersSalary *= o;
            decimal n = decimal.Parse(Console.ReadLine());

            decimal usaCurrency = decimal.Parse(Console.ReadLine());
            decimal s = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());



            decimal allSumNeeded = (builderbsSalary + receptionistsSalary + chambermaidsSalary + techniciansSalary + othersSalary + (n * usaCurrency) + s);

            decimal left = Math.Abs(m - allSumNeeded);

            if (m >= allSumNeeded)
            {
                Console.WriteLine("The amount is: {0:F2} lv.", Math.Abs(allSumNeeded));
                Console.WriteLine("YES \\ Left: {0:F2} lv.", Math.Abs(left));
            }
            else
            {
                Console.WriteLine("The amount is: {0:F2} lv.", Math.Abs(allSumNeeded));
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", Math.Abs(left));
            }


        }
    }
}
