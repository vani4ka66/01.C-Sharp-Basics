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
            long FG = long.Parse(Console.ReadLine());
            long FGA = long.Parse(Console.ReadLine());
            decimal n3P = decimal.Parse(Console.ReadLine());
            decimal TOV = decimal.Parse(Console.ReadLine());
            decimal ORB = decimal.Parse(Console.ReadLine());
            decimal OppDRB = decimal.Parse(Console.ReadLine());
            decimal FT = decimal.Parse(Console.ReadLine());
            decimal FTA = decimal.Parse(Console.ReadLine());

            decimal eFGPercent = ((FG + (0.5m * n3P)) / FGA);
            decimal TOVPercent = (TOV / (FGA + (0.44m * FTA) + TOV));
            decimal ORBPercent = ORB / (ORB + OppDRB);
            decimal FtPercent = FT / FGA;

            Console.WriteLine("eFG% {0:F3}", eFGPercent);
            Console.WriteLine("TOV% {0:F3}", TOVPercent);
            Console.WriteLine("ORB% {0:F3}", ORBPercent);
            Console.WriteLine("FT% {0:F3}", FtPercent);


        }
    }
}
