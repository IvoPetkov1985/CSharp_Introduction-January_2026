namespace _04.CinemaVoucher.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voucherSize = int.Parse(Console.ReadLine());
            int value = voucherSize;
            int tickets = 0;
            int products = 0;
            string purchase = Console.ReadLine();

            while (purchase != "End")
            {
                int currentPrice = 0;

                if (purchase.Length > 8)
                {
                    currentPrice = Convert.ToInt32(purchase[0]) + Convert.ToInt32(purchase[1]);
                }
                else
                {
                    currentPrice += Convert.ToInt32(purchase[0]);
                }

                if (currentPrice > value)
                {
                    break;
                }

                if (purchase.Length > 8)
                {
                    tickets++;
                }
                else
                {
                    products++;
                }

                value -= currentPrice;
                purchase = Console.ReadLine();
            }

            Console.WriteLine(tickets);
            Console.WriteLine(products);
        }
    }
}
