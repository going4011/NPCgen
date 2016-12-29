using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//========================================================================================
//persontalk: generates NPCs with unique characteristics
//
//Future ideas: Generate multiple NPCs simultaneously
//              Have the NPCs randomly interact
//              Allow the player to interact with the NPCs
namespace persontalk
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputStr = null;
            int userInput = 0;

            //Introduction
            Console.WriteLine("==========");
            Console.WriteLine("PersonTalk");
            Console.WriteLine("==========");
            Console.WriteLine();

            //Menu
            Console.WriteLine("1: Generate New Person");
            Console.WriteLine("2: Quit");

            //Generates a person and returns to menu as long as the user doesn't select "Quit"
            //If Quit: Program Terminates
            while (userInput != 2)
            {
                //User feedback
                userInputStr = Console.ReadLine();

                //Check to make sure that the value of userInputStr is either 1 or 2
                if (userInputStr == "1" || userInputStr == "2")
                {
                    //Convert user's input to int
                    userInput = Convert.ToInt32(userInputStr);
                    Console.WriteLine();

                    //Create a new random NPC
                    Console.WriteLine("Generating a new person...");
                    person person1 = new person();
                    person1.initialize();
                    Console.WriteLine();

                    //Print out the NPC's details
                    Console.WriteLine("Name: " + person1.Name);
                    Console.WriteLine("Age: " + person1.Age);
                    Console.WriteLine("Occupation: " + person1.Occupation);
                    Console.WriteLine("Personality: " + person1.Personality);
                }

                //If user enters anything other than 1 or 2, show an error message
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Entry. Try again.");
                }

                //Menu
                Console.WriteLine();
                Console.WriteLine("1: Generate New Person");
                Console.WriteLine("2: Quit");
            }
        }
    }
}
