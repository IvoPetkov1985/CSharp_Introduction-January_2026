namespace _02.ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int expectedSum = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int counter = 0;
            int cashSum = 0;
            int cardSum = 0;
            int cashSumCounter = 0;
            int cardSumCounter = 0;

            while (true)
            {
                if (command == "End")
                {
                    break;
                }

                counter++;
                int currentPrice = int.Parse(command);

                if (counter % 2 == 1)
                {
                    if (currentPrice > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        cashSum += currentPrice;
                        cashSumCounter++;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (currentPrice < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        cardSum += currentPrice;
                        cardSumCounter++;
                        Console.WriteLine("Product sold!");
                    }
                }

                if (cardSum + cashSum >= expectedSum)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (command != "End")
            {
                double averageCashSum = (double)cashSum / cashSumCounter;
                double averageCardSum = (double)cardSum / cardSumCounter;
                Console.WriteLine($"Average CS: {averageCashSum:F2}");
                Console.WriteLine($"Average CC: {averageCardSum:F2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
