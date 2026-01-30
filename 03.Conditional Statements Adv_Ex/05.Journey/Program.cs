namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string typeOfStay = string.Empty;
            double spentMoney = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                switch (season)
                {
                    case "summer": spentMoney = budget * 0.3; typeOfStay = "Camp"; break;
                    case "winter": spentMoney = budget * 0.7; typeOfStay = "Hotel"; break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                switch (season)
                {
                    case "summer": spentMoney = budget * 0.4; typeOfStay = "Camp"; break;
                    case "winter": spentMoney = budget * 0.8; typeOfStay = "Hotel"; break;
                }
            }
            else
            {
                destination = "Europe";
                spentMoney = budget * 0.9;
                typeOfStay = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfStay} - {spentMoney:F2}");
        }
    }
}
