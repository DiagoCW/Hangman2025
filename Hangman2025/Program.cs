using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hangman 2025");

        // game state init

        int nbrLives = 5;
        string secretWord = "gamedev";
        StringBuilder displayWord = new StringBuilder();

        for (int i = 0; i < secretWord.Length; i++)
        {
            displayWord.Append("_");
        }

        // game loop

        Console.WriteLine("Game starts!");
        while (true)
        {
            Console.WriteLine(displayWord.ToString() + " " + nbrLives.ToString() + " lives left");

            // fetch input
            string? input = Console.ReadLine();
            // Validate input
            if (input == null || input.Length == 0)
            {
                Console.WriteLine("Invalid input, try again.");
                continue;
            }

            char guessedLetter = input[0];

            Console.WriteLine("You guessed: " + guessedLetter);

            // check if guessed letter is correct
            bool correct = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (guessedLetter == secretWord[i])
                {
                    correct = true;
                    displayWord[i] = guessedLetter;
                }
            }

            if (correct)
                Console.WriteLine("Correct! ");
            else
            {
            Console.WriteLine("Wrong! ");
                nbrLives--;
            }

            if (nbrLives <= 0)
            {
                Console.WriteLine("You lost!");
                break;
            }

            if (secretWord == displayWord.ToString())
            {
                Console.WriteLine("You won!");
                break;
            }




            //break;
        }

        // game end

        
    }
}