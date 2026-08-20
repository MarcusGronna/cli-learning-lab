
Console.Title = "GUESSING GAME!";

var originalForegroundColor = Console.ForegroundColor;
var rand = new Random();
int randInt = rand.Next(1, 21);

Console.CancelKeyPress += (sender, e) =>
{
    e.Cancel = true;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\nThank you for playing!");
    Console.ForegroundColor = originalForegroundColor;
    Environment.Exit(0);
};

Console.WriteLine("You have three chances to guess the right number between 1 and 20");
int guesses = 3;

while (guesses > 0)
{
    guesses--;

    Console.Write("What is your guess? ");
    int.TryParse(Console.ReadLine(), out int guessedNumber);

    if (guessedNumber == randInt)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Congratulations, you won! The number was {0}. \nIt took you {1} guesses to find the answer",
            randInt, (3 - guesses));
        Console.ForegroundColor = originalForegroundColor;
        Environment.Exit(0);
    }

    Console.WriteLine("Your guess was not correct. You have {0} guesses left", guesses);
}

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Better luck next time! The number to be guessed was {0}.", randInt);
Console.ForegroundColor = originalForegroundColor;