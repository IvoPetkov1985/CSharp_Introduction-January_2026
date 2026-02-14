namespace _02.ReportSystem.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int expectedSum = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            List<int> cashSums = new();
            List<int> cardSums = new();

            int counter = 0;
            bool success = false;

            while (command != "End")
            {
                int productPrice = int.Parse(command);
                counter++;

                if ((counter % 2 == 1 && productPrice > 100) || (counter % 2 == 0 && productPrice < 10))
                {
                    Console.WriteLine("Error in transaction!");
                }
                else if (counter % 2 == 1)
                {
                    cashSums.Add(productPrice);
                    Console.WriteLine("Product sold!");
                }
                else if (counter % 2 == 0)
                {
                    cardSums.Add(productPrice);
                    Console.WriteLine("Product sold!");
                }

                if (cashSums.Sum() + cardSums.Sum() >= expectedSum)
                {
                    Console.WriteLine($"Average CS: {cashSums.Average():F2}");
                    Console.WriteLine($"Average CC: {cardSums.Average():F2}");
                    success = true;
                    break;
                }

                command = Console.ReadLine();
            }

            if (!success)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
