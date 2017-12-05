using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstShoot = Console.ReadLine();
            int rounds = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int simeonPoints = 0;
            int nakovPoints = 0;
            string winner = "";
            int winningRound = 0;

            if (simeonPoints < 500 || nakovPoints < 500)
            {

                for (int i = 1; i <= rounds; i++)
                {
                    int score1 = int.Parse(Console.ReadLine());
                    string successFail1 = Console.ReadLine();

                    if (firstShoot == "Simeon")
                    {
                        if (successFail1 == "success" && simeonPoints + score1 <= 500)
                        {
                            simeonPoints += score1;
                        }
                        if (simeonPoints == 500)
                        {
                            winner = "Simeon";
                            winningRound = i;
                            break;
                        }


                        int score2 = int.Parse(Console.ReadLine());
                        string successFail2 = Console.ReadLine();

                        if (successFail2 == "success" && nakovPoints + score2 <= 500)
                        {
                            nakovPoints += score2;
                        }
                        if (nakovPoints == 500)
                        {
                            winner = "Nakov";
                            winningRound = i;
                            break;
                        }
                    }
                    if (firstShoot == "Nakov")
                    {
                        if (successFail1 == "success" && nakovPoints + score1 <= 500)
                        {
                            nakovPoints += score1;
                        }
                        if (nakovPoints == 500)
                        {
                            winner = "Nakov";
                            winningRound = i;
                            break;
                        }

                        int score2 = int.Parse(Console.ReadLine());
                        string successFail2 = Console.ReadLine();

                        if (successFail2 == "success" && simeonPoints + score2 <= 500)
                        {
                            simeonPoints += score2;
                        }
                        if (simeonPoints == 500)
                        {
                            winner = "Simeon";
                            winningRound = i;
                            break;
                        }
                    }
                    if (firstShoot == "Simeon")
                    {
                        firstShoot = "Nakov";
                    }
                    else
                    {
                        firstShoot = "Simeon";
                    }
                }
            }

            if (winner == "Simeon")
            {
                Console.WriteLine(winner);
                Console.WriteLine(winningRound);
                Console.WriteLine(nakovPoints);
            }
            else if (winner == "Nakov")
            {
                Console.WriteLine(winner);
                Console.WriteLine(winningRound);
                Console.WriteLine(simeonPoints);
            }
            else if (//winner == String.Empty && 
                simeonPoints == nakovPoints)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(simeonPoints);
            }
            else if (simeonPoints > nakovPoints)
            {
                Console.WriteLine("Simeon");
                Console.WriteLine(simeonPoints - nakovPoints);
            }
            else
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(nakovPoints - simeonPoints);
            }

        }
    }
}
