namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double balance = 0;

            while (true)
            {
                if (command == "NoMoreMoney")
                {
                    break;
                }

                double deposit = double.Parse(command);

                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                balance += deposit;
                Console.WriteLine($"Increase: {deposit:F2}");
                command = Console.ReadLine();
            }

            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}
