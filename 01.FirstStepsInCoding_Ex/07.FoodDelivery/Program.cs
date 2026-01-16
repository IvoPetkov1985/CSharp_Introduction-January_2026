namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double veggieMenuPrice = 8.15;
            double deliveryPrice = 2.50;
            double dessertMultiplyer = 0.2;

            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veggieMenus = int.Parse(Console.ReadLine());

            double menusPrice = chickenMenus * chickenMenuPrice +
                fishMenus * fishMenuPrice +
                veggieMenus * veggieMenuPrice;

            double dessertPrice = menusPrice * dessertMultiplyer;
            double totalPurchasePrice = menusPrice + dessertPrice + deliveryPrice;

            Console.WriteLine(totalPurchasePrice);
        }
    }
}
