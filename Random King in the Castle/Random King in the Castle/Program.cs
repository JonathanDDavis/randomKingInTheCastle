using System;
using System.Collections.Generic;

namespace Random_King_in_the_Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string userValue = Console.ReadLine();
            Console.WriteLine("It is nice to meet you " + userValue);

            string newGame = "yes";
            while (newGame == "yes")
            {
                Random kingsLocation = new Random();
                List<string> location = new List<string>{"north", "south", "east", "west"};
                int index = kingsLocation.Next(location.Count);
                //Comment this out before the end
                Console.WriteLine(location[index]);

                Console.WriteLine(
                    "The king as summoned you to the castle. When you get to the castle the guards take you to the throne room. When you get in there the king says it is time to play a game. He disappears and you are supposed to find him.");
                Console.WriteLine(
                    "You look around and you can see 1 door on each wall. There is one to the North, South, East, and West. Which door would you want to go too.");
                string doorRoom = Console.ReadLine();
                string message = "";
                if (doorRoom == "north")
                {
                    message = "You found the treasure room.";
                    if (location[index] == userValue)
                        message = message + " You found the king.";
                    else
                        message = message + " The king was not there.";
                }

                else if (doorRoom == "south")
                {
                    message = "You walked into a storage room";
                    if (location[index] == userValue)
                        message = message + " You found the king.";
                    else
                        message = message + " The king was not there.";
                }

                else if (doorRoom == "east")
                { 
                    message = "You walked bedroom.";
                if (location[index] == userValue)
                    message = message + " You found the king.";
                else
                    message = message + " The king was not there.";
                }

                else if (doorRoom == "west")
                {
                    message = "You walked into a kitchen.";
                    if (location[index] == userValue)
                        message = message + " You found the king.";
                    else
                        message = message + " The king was not there.";
                }

                else
                    message = "Sorry, I do not understand you.";

                Console.WriteLine(message);
                Console.WriteLine("Thank you for playing my game. Do you want to play again?");

                string vaildChoose = "no";
                while (vaildChoose == "no")
                {
                    string endGame = Console.ReadLine();
                    if (endGame == "no")
                    {
                        vaildChoose = "yes";
                        newGame = "no";
                    }

                    else if (endGame == "yes")
                    {
                        vaildChoose = "yes";
                        Console.WriteLine("Okay.");
                    }

                    else
                        Console.WriteLine("Sorry that is not an invaild answer.");
                }
            }
        }
    }
}
