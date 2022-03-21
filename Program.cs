using System;
using System.Collections.Generic;
namespace firstConsoleApp_basketballStats
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            bool exitLoop = false;
          
            
            List<Player> playerNames = new List<Player>();
            

            playerNames.Add(new Player
            {
                Name = "Jordan",
                ShotsAttempted = 9,
                ShotsMade = 5,

            });
            playerNames.Add(new Player
            {
                Name = "Bird",
                ShotsAttempted = 7,
                ShotsMade = 5,
            });

            playerNames.Add(new Player
            {
                Name = "Barkley",
                ShotsAttempted = 5,
                ShotsMade = 4
            });


            Console.WriteLine("Welcome to the sports statistics app!");
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Please Enter Menu Number and Press Return");
                Console.WriteLine("1 Enter Player Information");
                Console.WriteLine("2 Display Player Information");
                Console.WriteLine("3 Exit");
                var menuSelection = Console.ReadLine();

                switch(menuSelection){

                    case "1":
                        Player p = new Player();

                        string lastName = AskName("What is the player's last name?");
                        p.Name = lastName;

                        string taken = Ask("How many shots have been taken?");
                        p.ShotsAttempted = int.Parse(taken);
                      
                        string made = AskTwo("How many shots have been made?");
                        p.ShotsMade = int.Parse(made);

                        Console.WriteLine("");
                        Console.WriteLine($"The field goal percentage is {(p.percentage * 100).ToString("##.##")}%");

                        playerNames.Add(p);

                        break;
                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine($"There are {playerNames.Count} players on the team.");
                        Console.WriteLine("");

                        foreach (Player player in playerNames)
                        {

                            Console.WriteLine($"Player: {player.Name} made {player.ShotsMade} shots out of {player.ShotsAttempted} for { (player.percentage *100).ToString("##.#")}%.");
                        }
                        break;
                    case "3":
                        exitLoop = true;
                        break;

                }


            }
            while (! exitLoop);
        }


        static string AskName(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        static string Ask(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        static string AskTwo(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

    }
}



