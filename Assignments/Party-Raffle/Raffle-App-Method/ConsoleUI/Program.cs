using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Party!\n\n");
            GetUserInfo();
            PrintGuestsName();
            Console.WriteLine();
            GetUserInput("\nPress enter to start the raffle!");
            MultiLineAnimation();
            PrintWinner();
        }

 
        private static Dictionary<int, string> Guests = new Dictionary<int, string>();
        private static int min = 1000;
        private static int max = 9999;
        private static int raffleNumber;
        private static Random _rdm = new Random();

        //Start writing your code here
        private static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;

        }
        private static void GetUserInfo()
        {
            string guestStatus;
            int guestCount = 1;
            //List<string> Guests 
            do
            {
                string userName = GetUserInput("Please enter your name for the raffle.\n");
                while (String.IsNullOrWhiteSpace(userName))
                {
                    Console.WriteLine("Name not acceptable!\n");
                    userName = GetUserInput("Please enter your name for the raffle.\n");
                }

                
                int randomNumber = GenerateRandomNumber(min, max);
                while (Guests.ContainsKey(randomNumber))
                {
                    randomNumber = GenerateRandomNumber(min, max);
                }

                AddGuestsInRaffle(randomNumber, userName);
                guestStatus = GetUserInput("\nWould you like to enter someone else?\n").ToLower();

                while (String.IsNullOrWhiteSpace(guestStatus))
                {

                   Console.WriteLine("Please answer Yes or No\n");
                   guestStatus = GetUserInput("Would you like to enter someone else?\n").ToLower();
                }
            }
            while (guestStatus == "yes");
        }

        private static int GenerateRandomNumber(int min, int max)
        {
            int value = _rdm.Next(min, max);
            return value;
        }

        private static void AddGuestsInRaffle(int raffleNumber, string guest)
        {
            Guests.Add(raffleNumber, guest);
        }

        private static void PrintGuestsName()
        {
            foreach(var name in Guests)
            {
                Console.WriteLine($"\n{name.Value} your raffle number is {name.Key}\n");
            }
        }

        private static int GetRaffleNumber(Dictionary<int,string> winner)
        {
            //List<int> raffleNumbers = new List<int>();
            //foreach(var name in winner)
            //{
            //    raffleNumbers.Add(name.Key);
            //}
            //int RaffleWinner = _rdm.Next(raffleNumbers.Count);
            List<int> raffleNumbers = winner.Keys.ToList();
            int raffleWinner = _rdm.Next(raffleNumbers.Count);
            return raffleNumbers[raffleWinner];
        }

        private static void PrintWinner()
        {
            int winner = _rdm.Next(Guests.Count - 1);
            Console.WriteLine($"The winner for Raffle Number {Guests.ElementAt(winner).Key} is {Guests.ElementAt(winner).Value}\nCongrats!");
        }


        private static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
        {
            var counter = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();

                switch (counter % 4)
                {
                    case 0:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    │││ \\   ║");
                            Console.WriteLine("         ║    │││  O  ║");
                            Console.WriteLine("         ║    OOO     ║");
                            break;
                        };
                    case 1:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║   / │││    ║");
                            Console.WriteLine("         ║  O  │││    ║");
                            Console.WriteLine("         ║     OOO    ║");
                            break;
                        };
                    case 3:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                }

                counter++;
                Thread.Sleep(200);
            }
        }
    }
}
