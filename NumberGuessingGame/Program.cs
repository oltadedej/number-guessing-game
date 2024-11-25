namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to the Number Guessing Game!");

            // Create a Random object to generate a random number
            Random random = new Random();
            int target = random.Next(1, 101); // Random number between 1 and 100

            // Variable to store the user's guess
            int guess = 0;

            // Explain the game rules to the user
            Console.WriteLine("Guess a number between 1 and 100:");

            // Loop until the user guesses correctly
            while (guess != target)
            {
                Console.Write("Enter your guess: "); // Prompt user for input

                // Try to parse the user's input; handle invalid entries
                try
                {
                    guess = int.Parse(Console.ReadLine()); // Convert input to integer

                    // Check if the guess is correct, too low, or too high
                    if (guess < target)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > target)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You guessed the right number!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            // End of the game
            Console.WriteLine("Thanks for playing!");
        }
    }
}
