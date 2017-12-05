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
            double priceOfTv = double.Parse(Console.ReadLine());
            int LoanYears = int.Parse(Console.ReadLine());
            double bankInterest = double.Parse(Console.ReadLine());
            double friendInterest = double.Parse(Console.ReadLine());

            double bankLoan = priceOfTv * Math.Pow((1 + bankInterest), LoanYears);
            double friendLoan = priceOfTv * (1 + friendInterest);

            if (bankLoan < friendLoan)
            {
                Console.WriteLine("{0:F2} Bank", bankLoan);
            }
            else
            {
                Console.WriteLine("{0:F2} Friend", friendLoan);
            }

        }
    }
}
