namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<int> numbers = new();

            while (true)
            {
                if (command == "Stop")
                {
                    break;
                }

                int currentNumber = int.Parse(command);
                numbers.Add(currentNumber);

                command = Console.ReadLine();
            }

            Console.WriteLine(numbers.Min());
        }
    }
}
