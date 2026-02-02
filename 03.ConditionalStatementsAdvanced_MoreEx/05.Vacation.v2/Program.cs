namespace _05.Vacation.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string stay = string.Empty;
            string destination = string.Empty;
            double price = 0;

            if (season == "Summer")
            {
                destination = "Alaska";
            }
            else if (season == "Winter")
            {
                destination = "Morocco";
            }

            if (budget <= 1000)
            {
                stay = "Camp";

                if (season == "Summer")
                {
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    price = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                stay = "Hut";

                if (season == "Summer")
                {
                    price = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    price = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                stay = "Hotel";
                price = budget * 0.90;
            }

            Console.WriteLine($"{destination} - {stay} - {price:F2}");
        }
    }
}
