namespace _04.CinemaVoucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voucherValue = int.Parse(Console.ReadLine());

            int boughtTickets = 0;
            int boughtProducts = 0;

            while (true)
            {
                string purchase = Console.ReadLine();

                if (purchase == "End")
                {
                    break;
                }

                int currentPrice = 0;

                if (purchase.Length > 8)
                {
                    currentPrice = (int)purchase[0] + (int)purchase[1];

                    if (currentPrice > voucherValue)
                    {
                        break;
                    }
                    else
                    {
                        voucherValue -= currentPrice;
                        boughtTickets++;
                    }
                }
                else
                {
                    currentPrice = (int)purchase[0];

                    if (currentPrice > voucherValue)
                    {
                        break;
                    }
                    else
                    {
                        voucherValue -= currentPrice;
                        boughtProducts++;
                    }
                }
            }

            Console.WriteLine(boughtTickets);
            Console.WriteLine(boughtProducts);
        }
    }
}
