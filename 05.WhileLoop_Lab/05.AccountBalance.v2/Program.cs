namespace _05.AccountBalance.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double total = 0;

            while (command != "NoMoreMoney")
            {
                double depositSum = double.Parse(command);

                if (depositSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += depositSum;
                Console.WriteLine($"Increase: {depositSum:F2}");

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
