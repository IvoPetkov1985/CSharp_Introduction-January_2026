namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double pricePerKilo = 0;
            bool isDayValid = true;
            bool isFruitValid = true;

            switch (fruit)
            {
                case "banana":

                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        pricePerKilo = 2.50;
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        pricePerKilo = 2.70;
                    }
                    else
                    {
                        isDayValid = false;
                    }

                    break;

                case "apple":

                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        pricePerKilo = 1.20;
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        pricePerKilo = 1.25;
                    }
                    else
                    {
                        isDayValid = false;
                    }

                    break;

                case "orange":

                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        pricePerKilo = 0.85;
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        pricePerKilo = 0.90;
                    }
                    else
                    {
                        isDayValid = false;
                    }

                    break;

                case "grapefruit":

                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        pricePerKilo = 1.45;
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        pricePerKilo = 1.60;
                    }
                    else
                    {
                        isDayValid = false;
                    }

                    break;

                case "kiwi":

                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        pricePerKilo = 2.70;
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        pricePerKilo = 3.00;
                    }
                    else
                    {
                        isDayValid = false;
                    }

                    break;

                case "pineapple":

                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        pricePerKilo = 5.50;
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        pricePerKilo = 5.60;
                    }
                    else
                    {
                        isDayValid = false;
                    }

                    break;

                case "grapes":

                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        pricePerKilo = 3.85;
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        pricePerKilo = 4.20;
                    }
                    else
                    {
                        isDayValid = false;
                    }

                    break;

                default:

                    isFruitValid = false;

                    break;
            }

            if (isFruitValid && isDayValid)
            {
                double finalPrice = pricePerKilo * quantity;
                Console.WriteLine($"{finalPrice:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
