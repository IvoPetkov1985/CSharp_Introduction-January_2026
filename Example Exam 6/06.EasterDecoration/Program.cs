namespace _06.EasterDecoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clientsCount = int.Parse(Console.ReadLine());

            double basketPrice = 1.50;
            double wreathPrice = 3.80;
            double bunnyPrice = 7.00;
            double turnover = 0;

            for (int client = 0; client < clientsCount; client++)
            {
                int counter = 0;
                double bill = 0;

                while (true)
                {
                    string product = Console.ReadLine();

                    if (product == "Finish")
                    {
                        break;
                    }

                    counter++;

                    switch (product)
                    {
                        case "basket": bill += basketPrice; break;
                        case "wreath": bill += wreathPrice; break;
                        case "chocolate bunny": bill += bunnyPrice; break;
                    }
                }

                if (counter % 2 == 0)
                {
                    bill -= bill * 0.20;
                }

                turnover += bill;
                Console.WriteLine($"You purchased {counter} items for {bill:F2} leva.");
            }

            double averageBill = turnover / clientsCount;
            Console.WriteLine($"Average bill per client is: {averageBill:F2} leva.");
        }
    }
}
