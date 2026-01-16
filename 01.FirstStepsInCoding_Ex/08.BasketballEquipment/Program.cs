namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double sneakersMultiplyer = 0.4;
            double jerseyMultiplyer = 0.2;
            double ballPercentage = 0.25;
            double accessoriesPercentage = 0.2;

            double sneakersPrice = annualFee * (1 - sneakersMultiplyer);
            double jerseyPrice = sneakersPrice * (1 - jerseyMultiplyer);
            double ballPrice = jerseyPrice * ballPercentage;
            double accessoriesPrice = ballPrice * accessoriesPercentage;

            double annualCosts = annualFee + sneakersPrice + jerseyPrice + ballPrice + accessoriesPrice;
            Console.WriteLine(annualCosts);
        }
    }
}
