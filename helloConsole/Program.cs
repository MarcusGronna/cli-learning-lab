namespace helloConsole;

class Program
{
    static void Main(string[] args)
    {
        var variable = args.Length > 0
            ? args[0]
            : "World";

        Console.WriteLine($"Hello, {variable}! Type: {variable.GetType()}");

        if (int.TryParse(variable, out int parsedVariable))
        {
            Console.WriteLine($"Hello, {parsedVariable}! Type: {parsedVariable.GetType()}");
        }
        else
        {
            Console.WriteLine($"Could not parse value to integer");
        }

    }
}
