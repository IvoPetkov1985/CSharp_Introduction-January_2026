namespace _05.Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int moviesCount = int.Parse(Console.ReadLine());

            double totalSum = 0;

            for (int movie = 0; movie < moviesCount; movie++)
            {
                string seriesName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                switch (seriesName)
                {
                    case "Thrones": price *= 0.5; break;
                    case "Lucifer": price *= 0.6; break;
                    case "Protector": price *= 0.7; break;
                    case "TotalDrama": price *= 0.8; break;
                    case "Area": price *= 0.9; break;
                }

                totalSum += price;
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"You bought all the series and left with {budget - totalSum:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {totalSum - budget:F2} lv. more to buy the series!");
            }
        }
    }
}
