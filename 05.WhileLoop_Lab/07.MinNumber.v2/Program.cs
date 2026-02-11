namespace _07.MinNumber.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int minNumber = int.MaxValue;

            while (command != "Stop")
            {
                int currentNumber = int.Parse(command);

                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
