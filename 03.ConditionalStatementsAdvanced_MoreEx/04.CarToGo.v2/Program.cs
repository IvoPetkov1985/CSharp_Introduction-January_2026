namespace _04.CarToGo.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string clientClass = string.Empty;
            string carType = string.Empty;
            double rent = 0;

            if (budget <= 100)
            {
                clientClass = "Economy class";

                if (season == "Summer")
                {
                    carType = "Cabrio";
                    rent = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    rent = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                clientClass = "Compact class";

                if (season == "Summer")
                {
                    carType = "Cabrio";
                    rent = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    rent = budget * 0.80;
                }
            }
            else if (budget > 500)
            {
                clientClass = "Luxury class";
                carType = "Jeep";
                rent = budget * 0.90;
            }

            Console.WriteLine(clientClass);
            Console.WriteLine($"{carType} - {rent:F2}");
        }
    }
}
