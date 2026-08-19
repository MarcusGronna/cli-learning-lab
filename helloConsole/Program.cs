namespace helloConsole;

class Program
{
    static void Main(string[] args)
    {
        Console.CancelKeyPress += (sender, e) =>
        {
            e.Cancel = true;
            Console.WriteLine("CancelKeyPress event raised!\nPerforming cleanup...");
            Environment.Exit(0);
        };

        int counter = 1;
        while (true)
        {
            Console.WriteLine($"Printing line number {counter}");
            counter++;
            Task delayTask = Task.Run(async () => await Task.Delay(1000));
            delayTask.Wait();
        }
    }
}
