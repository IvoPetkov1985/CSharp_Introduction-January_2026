namespace _08.PetShop.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodCount = int.Parse(Console.ReadLine());
            int catFoodCount = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.5;
            double catFoodPrice = 4.0;

            double finalSum = dogFoodCount * dogFoodPrice + catFoodCount * catFoodPrice;
            Console.WriteLine($"{finalSum} lv.");
        }
    }
}
