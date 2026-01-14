namespace _05.GreetingByName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            string outputText = $"Hello, {inputName}!";
            Console.WriteLine(outputText);
        }
    }
}
