namespace _02.ReportSystem.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int desiredSum = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int cashMoney = 0;
            int cardMoney = 0;
            int counter = 0;
            int cashPayCounter = 0;
            int cardPayCounter = 0;

            while (true)
            {
                if (command == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }

                int productPrice = int.Parse(command);
                counter++;

                if ((counter % 2 != 0 && productPrice > 100) || (counter % 2 == 0 && productPrice < 10))
                {
                    Console.WriteLine("Error in transaction!");
                }
                else if (counter % 2 != 0)
                {
                    cashMoney += productPrice;
                    cashPayCounter++;
                    Console.WriteLine("Product sold!");
                }
                else if (counter % 2 == 0)
                {
                    cardMoney += productPrice;
                    cardPayCounter++;
                    Console.WriteLine("Product sold!");
                }

                if (cardMoney + cashMoney >= desiredSum)
                {
                    double averageCash = (double)cashMoney / cashPayCounter;
                    double averageCard = (double)cardMoney / cardPayCounter;
                    Console.WriteLine($"Average CS: {averageCash:F2}");
                    Console.WriteLine($"Average CC: {averageCard:F2}");
                    break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
