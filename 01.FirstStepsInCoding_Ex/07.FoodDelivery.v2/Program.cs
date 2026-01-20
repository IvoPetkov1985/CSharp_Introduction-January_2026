namespace _07.FoodDelivery.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double veggieMenuPrice = 8.15;
            int dessertPercent = 20;
            double deliveryPrice = 2.50;

            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veggieMenus = int.Parse(Console.ReadLine());

            double totalSum = (chickenMenus * chickenMenuPrice + fishMenus * fishMenuPrice + veggieMenus * veggieMenuPrice) *
                (1 + dessertPercent / 100.0) + deliveryPrice;
            Console.WriteLine(totalSum);
        }
    }
}
