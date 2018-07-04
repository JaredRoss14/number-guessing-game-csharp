using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            getAppInfo(); // Run Get App function to display info

            greetUser(); // Ask for users name and greet

            while (true) {

                // Create a new random number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Guess variable
                int guess = 0;

                // Ask user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber) {
                    // Get users input
                    string input = Console.ReadLine();

                    // Verify entry is an integer
                    if(!int.TryParse(input, out guess)) {
                        
                        // Print error message
                        printColorMessage(ConsoleColor.Yellow, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber) {
                        
                        // Print incorrect number message
                        printColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print success message
                printColorMessage(ConsoleColor.Green, "You are correct, you win!");

                // Ask to play again
                Console.WriteLine("Want to play again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y") {
                    continue;
                } else if (answer == "N") {
                    return;
                } else {
                    return;
                }
            }
        }

        // Display app info
        static void getAppInfo() {
            
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jared Ross";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset console color
            Console.ResetColor();
        }

        // Get and display user's name
        static void greetUser() {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Write out user name
            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }

        // Print color message
        static void printColorMessage(ConsoleColor color, string message) {
            // Change text color
            Console.ForegroundColor = color;

            // Alert user the guess is not a number
            Console.WriteLine(message);

            // Reset console color
            Console.ResetColor();
        }
    }
}
