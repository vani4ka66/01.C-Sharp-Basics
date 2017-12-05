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
            int dayOfWeek = int.Parse(Console.ReadLine());
            decimal moneyHas = decimal.Parse(Console.ReadLine());
            decimal desireAlcohol = decimal.Parse(Console.ReadLine());

            decimal boughtAlcohol = 0;

            switch (dayOfWeek)
            {
                case 0:
                    boughtAlcohol = (moneyHas / 25m); break;
                case 1:
                    boughtAlcohol = (moneyHas / 21m); break;
                case 2:
                    boughtAlcohol = (moneyHas / 14m); break;
                case 3:
                    boughtAlcohol = (moneyHas / 17m); break;
                case 4:
                    boughtAlcohol = (moneyHas / 45m); break;
                case 5:
                    boughtAlcohol = (moneyHas / 59m); break;
                case 6:
                    boughtAlcohol = (moneyHas / 42m); break;
            }


            string condition;

            if (boughtAlcohol > 1.5m)
            {
                condition = "very drunk";
            }
            else if (boughtAlcohol < 1m)
            {
                condition = "sober";
            }
            else
            {
                condition = "drunk";
            }
            if (desireAlcohol < boughtAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends", condition, (boughtAlcohol - desireAlcohol));
            }
            else if (desireAlcohol == boughtAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", condition, (desireAlcohol - boughtAlcohol));
            }

        }
    }
}
