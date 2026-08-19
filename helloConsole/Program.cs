namespace helloConsole;

class Program
{
    static void Main(string[] args)
    {
        var keyPressed = Console.ReadKey(true).Key;

        while (keyPressed != ConsoleKey.Escape)
        {
            Console.WriteLine($"You pressed {keyPressed}");
            keyPressed = Console.ReadKey(true).Key;
        }
    }
}
