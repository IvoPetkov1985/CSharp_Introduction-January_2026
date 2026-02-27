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

            for (int i = 0; i < clients; i++)
            {
                double clientBill = 0;
                int products = 0;
                string purchase = Console.ReadLine();

                while (purchase != "Finish")
                {
                    switch (purchase)
                    {
                        case "basket": clientBill += basketPrice; break;
                        case "wreath": clientBill += wreathPrice; break;
                        case "chocolate bunny": clientBill += bunnyPrice; break;
                    }

                    products++;

                    purchase = Console.ReadLine();
                }

                if (products % 2 == 0)
                {
                    clientBill -= clientBill * 0.2;
                }

                Console.WriteLine($"You purchased {products} items for {clientBill:F2} leva.");
                totalBill += clientBill;
            }

            double averageBill = totalBill / clients;
            Console.WriteLine($"Average bill per client is: {averageBill:F2} leva.");
        }
    }
}
