namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogPouch = 2.50;
            double catPouch = 4.00;

            int dogPouchCount = int.Parse(Console.ReadLine());
            int catPouchCount = int.Parse(Console.ReadLine());

            double dogFoodPrice = dogPouch * dogPouchCount;
            double catFoodPrice = catPouch * catPouchCount;
            double finalSum = dogFoodPrice + catFoodPrice;

            Console.WriteLine(finalSum + " lv.");
        }
    }
}
