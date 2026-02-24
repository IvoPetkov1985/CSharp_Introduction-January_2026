namespace _04.TouristShop.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int productCounter = 0;
            double paidSum = 0;

            while (command != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());
                productCounter++;

                if (productCounter % 3 == 0)
                {
                    productPrice /= 2;
                }

                if (productPrice > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {productPrice - budget:F2} leva!");
                    break;
                }

                budget -= productPrice;
                paidSum += productPrice;
                command = Console.ReadLine();
            }

            if (command == "Stop")
            {
                Console.WriteLine($"You bought {productCounter} products for {paidSum:F2} leva.");
            }
        }
    }
}
