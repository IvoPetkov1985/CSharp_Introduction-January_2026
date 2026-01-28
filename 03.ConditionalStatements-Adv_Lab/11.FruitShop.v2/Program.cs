namespace _11.FruitShop.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double pricePerKg = 0;
            bool isFruitValid = true;
            bool isDayValid = true;

            if (dayOfWeek != "Monday" &&
                dayOfWeek != "Tuesday" &&
                dayOfWeek != "Wednesday" &&
                dayOfWeek != "Thursday" &&
                dayOfWeek != "Friday" &&
                dayOfWeek != "Saturday" &&
                dayOfWeek != "Sunday")
            {
                isDayValid = false;
            }

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":

                    switch (fruit)
                    {
                        case "banana": pricePerKg = 2.50; break;
                        case "apple": pricePerKg = 1.20; break;
                        case "orange": pricePerKg = 0.85; break;
                        case "grapefruit": pricePerKg = 1.45; break;
                        case "kiwi": pricePerKg = 2.70; break;
                        case "pineapple": pricePerKg = 5.50; break;
                        case "grapes": pricePerKg = 3.85; break;
                        default: isFruitValid = false; break;
                    }

                    break;
                case "Saturday":
                case "Sunday":

                    switch (fruit)
                    {
                        case "banana": pricePerKg = 2.70; break;
                        case "apple": pricePerKg = 1.25; break;
                        case "orange": pricePerKg = 0.90; break;
                        case "grapefruit": pricePerKg = 1.60; break;
                        case "kiwi": pricePerKg = 3.00; break;
                        case "pineapple": pricePerKg = 5.60; break;
                        case "grapes": pricePerKg = 4.20; break;
                        default: isFruitValid = false; break;
                    }

                    break;
            }

            if (isFruitValid && isDayValid)
            {
                double finalPrice = pricePerKg * quantity;
                Console.WriteLine("{0:F2}", finalPrice);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
