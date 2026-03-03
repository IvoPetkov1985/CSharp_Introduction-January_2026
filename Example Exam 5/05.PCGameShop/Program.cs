namespace _05.PCGameShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesSold = int.Parse(Console.ReadLine());

            int hearthstoneCount = 0;
            int forniteCount = 0;
            int overwatchCount = 0;
            int othersCount = 0;

            for (int game = 0; game < gamesSold; game++)
            {
                string name = Console.ReadLine();

                switch (name)
                {
                    case "Hearthstone": hearthstoneCount++; break;
                    case "Fornite": forniteCount++; break;
                    case "Overwatch": overwatchCount++; break;
                    default: othersCount++; break;
                }
            }

            double hearthStonePercent = hearthstoneCount * 100d / gamesSold;
            double fornitePercent = forniteCount * 100d / gamesSold;
            double overwatchPercent = overwatchCount * 100d / gamesSold;
            double othersPercent = othersCount * 100d / gamesSold;

            Console.WriteLine($"Hearthstone - {hearthStonePercent:F2}%");
            Console.WriteLine($"Fornite - {fornitePercent:F2}%");
            Console.WriteLine($"Overwatch - {overwatchPercent:F2}%");
            Console.WriteLine($"Others - {othersPercent:F2}%");
        }
    }
}
