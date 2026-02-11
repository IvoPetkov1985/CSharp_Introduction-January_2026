namespace _06.MaxNumber.v2
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
                    Console.WriteLine(numbers.Max());
                    break;
                }

                int currentNum = int.Parse(command);
                numbers.Add(currentNum);

                command = Console.ReadLine();
            }
        }
    }
}
