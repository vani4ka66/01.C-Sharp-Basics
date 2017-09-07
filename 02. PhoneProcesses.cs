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
        // 22% Solved!!!
        
            //String number = "254";
            //int fromBase = 10;
            //int toBase = 16;

            //String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            //Console.WriteLine(result);

            string[] startPercents = Console.ReadLine().Split('%');
            string command = Console.ReadLine().ToUpper();
            int start = int.Parse(startPercents[0]);
            int result = 0;
            int count = 0;
            int countAll = 0;
            bool needRecharge = false;

            while (command != "END")
            {
                string[] commandArr = command.Split('_');
                string secondPercent = commandArr[1];
                string[] secondArr = secondPercent.Split('%');
                int end = int.Parse(secondArr[0]);

                if (needRecharge == false)
                {
                    result = start - end;
                    start = result;
                    count++;

                }
                if (result <= 15 && result > 0)
                {
                    needRecharge = true;

                }

                if (start <= 15 && result > 0)
                {
                    needRecharge = true;
                }

                command = Console.ReadLine();
                countAll++;
            }
           if (result <= 0)
            {
                Console.WriteLine("Phone Off");
            }
            else if (result > 15)
            {
                Console.WriteLine("Successful complete -> {0}%", result);
            }
            else if (result <= 15 && result > 0)
            {
                Console.WriteLine("Connect charger -> {0}%", result);
                Console.WriteLine("Programs left -> {0}", countAll);
                Console.WriteLine(count);
            }



        }
    }
}
