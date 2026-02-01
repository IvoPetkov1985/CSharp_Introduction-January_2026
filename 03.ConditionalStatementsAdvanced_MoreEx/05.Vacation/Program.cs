namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = string.Empty;
            string typeOfStay = string.Empty;
            double priceOfStay = 0;

            if (budget <= 1000)
            {
                typeOfStay = "Camp";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        priceOfStay = budget * 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        priceOfStay = budget * 0.45;
                        break;
                }
            }
            else if (budget <= 3000)
            {
                typeOfStay = "Hut";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        priceOfStay = budget * 0.80;
                        break;
                    case "Winter":
                        location = "Morocco";
                        priceOfStay = budget * 0.60;
                        break;
                }
            }
            else
            {
                typeOfStay = "Hotel";
                priceOfStay = budget * 0.90;

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        break;
                    case "Winter":
                        location = "Morocco";
                        break;
                }
            }

            Console.WriteLine($"{location} - {typeOfStay} - {priceOfStay:F2}");
        }
    }
}
