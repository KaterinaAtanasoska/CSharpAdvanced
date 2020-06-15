using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wins = new List<string>();
            string userOption;
            string userPick = "pick";
            string menuOption;
            while (true) { 
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Stats");
            Console.WriteLine("3. Exit");
            menuOption = Console.ReadLine();
                if (menuOption == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("Pick option (insert number):");
                        Console.WriteLine("1. Rock");
                        Console.WriteLine("2. Paper");
                        Console.WriteLine("3. Scissors");
                        userOption = Console.ReadLine();

                        switch (userOption)
                        {
                            case "1":
                                userPick = "rock";
                                Console.WriteLine($"User picks: {userPick}");
                                break;
                            case "2":
                                userPick = "paper";
                                Console.WriteLine($"User picks: {userPick}");
                                break;
                            case "3":
                                userPick = "scissors";
                                Console.WriteLine($"User picks: {userPick}");
                                break;
                            default:
                                Console.WriteLine("Incorrect input");
                                break;
                        }


                        List<string> list = new List<string> { "rock", "paper", "scissors" };
                        Random r = new Random();
                        int index = r.Next(list.Count);
                        string appPick = list[index];
                        Console.WriteLine($"Application picks: {appPick}");

                        if (userPick == "rock" && appPick == "rock")
                        {
                            Console.WriteLine("Equal!");
                            wins.Add("Equal!");
                        }
                        else if (userPick == "rock" && appPick == "paper")
                        {
                            Console.WriteLine("Application win!");
                            wins.Add("Application win!");
                        }
                        else if (userPick == "rock" && appPick == "scissors")
                        {
                            Console.WriteLine("User win!");
                            wins.Add("User win!");
                        }
                        else if (userPick == "paper" && appPick == "scissors")
                        {
                            Console.WriteLine("Application win!");
                            wins.Add("Application win!");
                        }
                        else if (userPick == "paper" && appPick == "rock")
                        {
                            Console.WriteLine("User win!");
                            wins.Add("User win!");
                        }
                        else if (userPick == "paper" && appPick == "paper")
                        {
                            Console.WriteLine("Equal!");
                            wins.Add("Equal!");
                        }
                        else if (userPick == "scissors" && appPick == "scissors")
                        {
                            Console.WriteLine("Equal!");
                            wins.Add("Equal!");
                        }
                        else if (userPick == "scissors" && appPick == "rock")
                        {
                            Console.WriteLine("Application win!");
                            wins.Add("Application win!");
                        }
                        else if (userPick == "scissors" && appPick == "paper")
                        {
                            Console.WriteLine("User win!");
                            wins.Add("User win!");
                        }

                        Console.WriteLine("New game? (y/n)");
                        string newGame = Console.ReadLine();
                        if (newGame == "y" || newGame == "Y")
                        {
                            continue;
                        }
                        else if (newGame == "n" || newGame == "N")
                        {
                            break;
                        }
                    }
                }
                else if (menuOption == "2")
                {
                    int appWins = 0;
                    int userWins = 0;
                    int totalGames = 0;

                    foreach (var win in wins)
                    {
                        totalGames += 1;
                        if (win == "User win!")
                        {
                            userWins += 1;
                        }
                        if (win == "Application win!")
                        {
                            appWins += 1;
                        }
                    }

                    Console.WriteLine($"Total games: {totalGames}");
                    Console.WriteLine($"User wins: {userWins}");
                    Console.WriteLine($"Application wins: {appWins}");
                }
                else if (menuOption == "3")
                {
                    break;
                }
            
            }
        }
    }
}
