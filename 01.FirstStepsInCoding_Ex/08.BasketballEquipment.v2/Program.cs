namespace _08.BasketballEquipment.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sneakersPercent = 40;
            int outfitPercent = 20;
            int ballDivisor = 4;
            int accessoriesDivisor = 5;

            int tax = int.Parse(Console.ReadLine());

            double sneakersPrice = tax * (1 - sneakersPercent / 100.0);
            double outfitPrice = sneakersPrice * (1 - outfitPercent / 100.0);
            double ballPrice = outfitPrice / ballDivisor;
            double accessoriesPrice = ballPrice / accessoriesDivisor;

            double totalSum = tax + sneakersPrice + outfitPrice + ballPrice + accessoriesPrice;

            Console.WriteLine(totalSum);
        }
    }
}
