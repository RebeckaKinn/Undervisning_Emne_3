using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Undervisning_Emne_3
{
    internal class Game
    {
        private bool user = false;
        private bool isRunning = true;
        private int userScore = 0;
        private int rounds = 0;
        public void Run()
        {
            Random rand = new Random();
            while (isRunning)
            {
                rounds++;
                user = false;
                Console.Clear();
                Console.WriteLine($"Rounds - {rounds}\nScore - {userScore}");
                Console.WriteLine("1 - stein\n2 - saks\n3 - papir\n4 - Exit");
                int answer = Convert.ToInt32(Console.ReadLine());

                if(answer == 4)
                {
                    isRunning = false;
                    continue;
                }
               
                int computerChoice = rand.Next(1, 4);
                if (answer == computerChoice)
                {
                    Console.WriteLine("Svarene er like!");
                }
                else if (CheckWinner(answer, computerChoice))
                {
                    Console.WriteLine($"Du valgte {AnswerToString(answer)}, programmet valgte {AnswerToString(computerChoice)}");
                    if (user) Console.WriteLine("Du vant!");
                    else Console.WriteLine("Du tapte!");
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

            }

        }

        private bool CheckWinner(int answer, int choice)
        {
            if (answer == 1 && choice == 2 || answer == 2 && choice == 3 || answer == 3 && choice == 1)
            {
                userScore++;
                user = true;
                return true;
            }
            else if (choice == 1 && answer == 2 || choice == 2 && answer == 3 || choice == 3 && answer == 1)
            {
                return true;
            }
            else
            {
                rounds--;
                return false;
            }
        }
        private string AnswerToString(int answer)
        {
            switch (answer)
            {
                case 1:
                    return "Stein";
                case 2:
                    return "Saks";
                case 3:
                    return "Papir";
                default:
                    return "error";
            }
        }
    }
}
