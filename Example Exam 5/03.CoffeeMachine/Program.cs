namespace _03.CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugarStatus = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());

            double singlePrice = 0;

            if (drink == "Espresso")
            {
                switch (sugarStatus)
                {
                    case "Without": singlePrice = 0.90; break;
                    case "Normal": singlePrice = 1.00; break;
                    case "Extra": singlePrice = 1.20; break;
                }
            }
            else if (drink == "Cappuccino")
            {
                switch (sugarStatus)
                {
                    case "Without": singlePrice = 1.00; break;
                    case "Normal": singlePrice = 1.20; break;
                    case "Extra": singlePrice = 1.60; break;
                }
            }
            else if (drink == "Tea")
            {
                switch (sugarStatus)
                {
                    case "Without": singlePrice = 0.50; break;
                    case "Normal": singlePrice = 0.60; break;
                    case "Extra": singlePrice = 0.70; break;
                }
            }

            double finalSum = singlePrice * drinksCount;

            if (sugarStatus == "Without")
            {
                finalSum *= 0.65;
            }

            if (drink == "Espresso" && drinksCount >= 5)
            {
                finalSum *= 0.75;
            }

            if (finalSum > 15.00)
            {
                finalSum *= 0.80;
            }

            Console.WriteLine($"You bought {drinksCount} cups of {drink} for {finalSum:F2} lv.");
        }
    }
}
