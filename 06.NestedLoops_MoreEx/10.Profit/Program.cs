namespace _10.Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oneLvCoins = int.Parse(Console.ReadLine());
            int twoLvCoins = int.Parse(Console.ReadLine());
            int fiveLvBanknotes = int.Parse(Console.ReadLine());
            int sumToPay = int.Parse(Console.ReadLine());

            for (int i = 0; i <= oneLvCoins; i++)
            {
                for (int j = 0; j <= twoLvCoins; j++)
                {
                    for (int k = 0; k <= fiveLvBanknotes; k++)
                    {
                        if ((i * 1 + j * 2 + k * 5) == sumToPay)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sumToPay} lv.");
                        }
                    }
                }
            }
        }
    }
}
