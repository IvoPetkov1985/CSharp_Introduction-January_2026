namespace _01.TennisEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tennisRacketPrice = double.Parse(Console.ReadLine());
            int tennisRacketsCount = int.Parse(Console.ReadLine());
            int pairsSneakersCount = int.Parse(Console.ReadLine());

            double pairSneakersPrice = tennisRacketPrice / 6;
            double sumRacketsSneakers = tennisRacketPrice * tennisRacketsCount + pairsSneakersCount * pairSneakersPrice;
            double otherEquipmentPrice = sumRacketsSneakers * 0.2;
            double totalSum = sumRacketsSneakers + otherEquipmentPrice;
            double playerSum = totalSum / 8;
            double sponsorSum = totalSum - playerSum;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(playerSum)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsorSum)}");
        }
    }
}
