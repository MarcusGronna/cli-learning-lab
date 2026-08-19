namespace helloConsole;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter some text and hit ENTER");

        string? line;
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            Console.WriteLine(line);
        }

        Console.WriteLine("bye!");
    }
}
