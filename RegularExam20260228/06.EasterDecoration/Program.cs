namespace _06.EasterDecoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());

            double basketPrice = 1.50;
            double wreathPrice = 3.80;
            double bunnyPrice = 7.00;

            double totalBill = 0;

            for (int client = 0; client < clients; client++)
            {
                double clientBill = 0;
                int productCounter = 0;

                string purchase = Console.ReadLine();

                while (purchase != "Finish")
                {
                    productCounter++;

                    switch (purchase)
                    {
                        case "basket": clientBill += basketPrice; break;
                        case "wreath": clientBill += wreathPrice; break;
                        case "chocolate bunny": clientBill += bunnyPrice; break;
                    }

                    purchase = Console.ReadLine();
                }

                if (productCounter % 2 == 0)
                {
                    clientBill -= clientBill * 0.20;
                }

                Console.WriteLine($"You purchased {productCounter} items for {clientBill:F2} leva.");
                totalBill += clientBill;
            }

            double averageBill = totalBill / clients;
            Console.WriteLine($"Average bill per client is: {averageBill:F2} leva.");
        }
    }
}
