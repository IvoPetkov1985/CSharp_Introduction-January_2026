namespace _03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char isHoliday = char.Parse(Console.ReadLine());

            double arrangementPrice = 2.00;
            double chrysanthemumPrice = 0;
            double rosePrice = 0;
            double tulipPrice = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemumPrice = 2.00;
                    rosePrice = 4.10;
                    tulipPrice = 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    chrysanthemumPrice = 3.75;
                    rosePrice = 4.50;
                    tulipPrice = 4.15;
                    break;
            }

            double allFlowersPrice = chrysanthemumPrice * chrysanthemumsCount + rosePrice * rosesCount + tulipPrice * tulipsCount;

            if (isHoliday == 'Y')
            {
                allFlowersPrice *= 1.15;
            }

            if (season == "Spring" && tulipsCount > 7)
            {
                allFlowersPrice *= 0.95;
            }

            if (season == "Winter" && rosesCount >= 10)
            {
                allFlowersPrice *= 0.90;
            }

            if (chrysanthemumsCount + rosesCount + tulipsCount > 20)
            {
                allFlowersPrice *= 0.80;
            }

            allFlowersPrice += arrangementPrice;

            Console.WriteLine($"{allFlowersPrice:F2}");
        }
    }
}
