namespace _03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double busTonPrice = 200;
            double truckTonPrice = 175;
            double trainTonPrice = 120;

            int busTons = 0;
            int truckTons = 0;
            int trainTons = 0;
            double totalMoney = 0;

            for (int i = 1; i <= count; i++)
            {
                int currentTons = int.Parse(Console.ReadLine());

                if (currentTons <= 3)
                {
                    busTons += currentTons;
                    totalMoney += currentTons * busTonPrice;
                }
                else if (currentTons >= 4 && currentTons <= 11)
                {
                    truckTons += currentTons;
                    totalMoney += currentTons * truckTonPrice;
                }
                else if (currentTons >= 12)
                {
                    trainTons += currentTons;
                    totalMoney += currentTons * trainTonPrice;
                }
            }

            int totalTons = busTons + truckTons + trainTons;
            double averagePricePerTon = totalMoney / (totalTons * 1.0);
            double busPercentage = busTons * 100.0 / (totalTons * 1.0);
            double truckPercentage = truckTons * 100.0 / (totalTons * 1.0);
            double trainPercentage = trainTons * 100.0 / (totalTons * 1.0);

            Console.WriteLine($"{averagePricePerTon:F2}");
            Console.WriteLine($"{busPercentage:F2}%");
            Console.WriteLine($"{truckPercentage:F2}%");
            Console.WriteLine($"{trainPercentage:F2}%");
        }
    }
}
