using System;
using System.Net.NetworkInformation;
using Microsoft.Win32;

//Namespace
namespace Number_Guesser
{
    //Namespace
   class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            // Set App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Miriam Phily";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset color
            Console.ResetColor();

            // Ask user name
            Console.WriteLine("Hi, what is your name?");

            // Get user answer
             string answer = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", answer);

            //Init correct number
            int correctNumber = 7;

            //Init guess var
            int guess = 0;

            //Ask user for a number
            Console.WriteLine("Guess a number ranging from 1 to 10");

            //If guess is not correct 
            while (guess!= correctNumber) {
                //Get users input
                string input = Console.ReadLine();

                //Ensure that its a number
                if (!int.TryParse(input, out correctNumber)) {
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //let user know that it is not a number
                    Console.WriteLine("Please enter an actual number");

                    //Reset color
                    Console.ResetColor();

                    //Carry on
                    continue;
                }


                    //Make to int and put in guess
                    guess = Int32.Parse(input);
            }

            //Match guess to a correct answer
            if( guess!= 7) {
                //Change text color
                Console.ForegroundColor = ConsoleColor.Red;

                //let user know that they used the wrong number
                Console.WriteLine("Wrong number please take another guess");

                //Reset color
                Console.ResetColor ();

            }

            //Output corret message

            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Tell user it is the write number
            Console.WriteLine("That is correct!");

            //Reset color
            Console.ResetColor();


        }
    }
}
