namespace helloConsole;

class Program
{
    static void Main(string[] args)
    {
        var originalBackgroundColor = Console.BackgroundColor;
        var originalForegroundColor = Console.ForegroundColor;

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.Title = "My Console Application";
        Console.WriteLine("Hello my app");

        Console.BackgroundColor = originalBackgroundColor;
        Console.ForegroundColor = originalForegroundColor;

        Console.ReadKey(true);
    }
}
