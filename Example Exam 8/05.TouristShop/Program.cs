namespace _05.TouristShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double money = budget;
            int productCounter = 0;

            while (true)
            {
                string productName = Console.ReadLine();

                if (productName == "Stop")
                {
                    Console.WriteLine($"You bought {productCounter} products for {budget - money:F2} leva.");
                    break;
                }

                double price = double.Parse(Console.ReadLine());
                productCounter++;

                if (productCounter % 3 == 0)
                {
                    price /= 2;
                }

                if (price > money)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {price - money:F2} leva!");
                    break;
                }

                money -= price;
            }
        }
    }
}
