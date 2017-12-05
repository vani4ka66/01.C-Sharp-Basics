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
            decimal money = decimal.Parse(Console.ReadLine()) * 1.94m;
            int countOfMatches = 0;
            decimal moneyPaid = 0;
            int arsenalPoints = 0;
            int chelseaPoints = 0;
            int evertonPoints = 0;
            int liverpoolPoints = 0;
            int manCityPoints = 0;
            int manUnPoints = 0;
            int southampthonPoints = 0;
            int tottenhamPoints = 0;


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End of the league.")
                {
                    break;
                }

                string[] command = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); ;

                countOfMatches++;
                string team1 = command[0];
                string result = command[1];
                string team2 = command[2];

                if (result == "1")
                {

                    if (team1 == "Arsenal")
                    {
                        arsenalPoints += 3;
                    }
                    else if (team1 == "Chelsea")
                    {
                        chelseaPoints += 3;
                    }
                    else if (team1 == "Everton")
                    {
                        evertonPoints += 3;
                    }
                    else if (team1 == "Liverpool")
                    {
                        liverpoolPoints += 3;
                    }
                    else if (team1 == "ManchesterCity")
                    {
                        manCityPoints += 3;
                    }
                    else if (team1 == "ManchesterUnited")
                    {
                        manUnPoints += 3;
                    }
                    else if (team1 == "Southampton")
                    {
                        southampthonPoints += 3;
                    }
                    else if (team1 == "Tottenham")
                    {
                        tottenhamPoints += 3;
                    }


                }
                else if (result == "2")
                {

                    if (team2 == "Arsenal")
                    {
                        arsenalPoints += 3;
                    }
                    else if (team2 == "Chelsea")
                    {
                        chelseaPoints += 3;
                    }
                    else if (team2 == "Everton")
                    {
                        evertonPoints += 3;
                    }
                    else if (team2 == "Liverpool")
                    {
                        liverpoolPoints += 3;
                    }
                    else if (team2 == "ManchesterCity")
                    {
                        manCityPoints += 3;
                    }
                    else if (team2 == "ManchesterUnited")
                    {
                        manUnPoints += 3;
                    }
                    else if (team2 == "Southampton")
                    {
                        southampthonPoints += 3;
                    }
                    else if (team2 == "Tottenham")
                    {
                        tottenhamPoints += 3;
                    }
                }
                else if (result == "X")
                {

                    if (team1 == "Arsenal" || team2 == "Arsenal")
                    {
                        arsenalPoints += 1;
                    }
                    if (team1 == "Chelsea" || team2 == "Chelsea")
                    {
                        chelseaPoints += 1;
                    }
                    if (team1 == "Everton" || team2 == "Everton")
                    {
                        evertonPoints += 1;
                    }
                    if (team1 == "Liverpool" || team2 == "Liverpool")
                    {
                        liverpoolPoints += 1;
                    }
                    if (team1 == "ManchesterCity" || team2 == "ManchesterCity")
                    {
                        manCityPoints += 1;
                    }
                    if (team1 == "ManchesterUnited" || team2 == "ManchesterUnited")
                    {
                        manUnPoints += 1;
                    }
                    if (team1 == "Southampton" || team2 == "Southampton")
                    {
                        southampthonPoints += 1;
                    }
                    if (team1 == "Tottenham" || team2 == "Tottenham")
                    {
                        tottenhamPoints += 1;
                    }
                }

                moneyPaid = money * countOfMatches;

            }
            Console.WriteLine("{0:F2}lv.", moneyPaid);
            Console.WriteLine("Arsenal - {0} points.", arsenalPoints);
            Console.WriteLine("Chelsea - {0} points.", chelseaPoints);
            Console.WriteLine("Everton - {0} points.", evertonPoints);
            Console.WriteLine("Liverpool - {0} points.", liverpoolPoints);
            Console.WriteLine("Manchester City - {0} points.", manCityPoints);
            Console.WriteLine("Manchester United - {0} points.", manUnPoints);
            Console.WriteLine("Southampton - {0} points.", southampthonPoints);
            Console.WriteLine("Tottenham - {0} points.", tottenhamPoints);

        }
    }
}
