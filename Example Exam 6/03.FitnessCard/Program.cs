namespace _03.FitnessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double monthlyPassPrice = 0;

            if (sport == "Gym")
            {
                switch (gender)
                {
                    case 'm': monthlyPassPrice = 42; break;
                    case 'f': monthlyPassPrice = 35; break;
                }
            }
            else if (sport == "Boxing")
            {
                switch (gender)
                {
                    case 'm': monthlyPassPrice = 41; break;
                    case 'f': monthlyPassPrice = 37; break;
                }
            }
            else if (sport == "Yoga")
            {
                switch (gender)
                {
                    case 'm': monthlyPassPrice = 45; break;
                    case 'f': monthlyPassPrice = 42; break;
                }
            }
            else if (sport == "Zumba")
            {
                switch (gender)
                {
                    case 'm': monthlyPassPrice = 34; break;
                    case 'f': monthlyPassPrice = 31; break;
                }
            }
            else if (sport == "Dances")
            {
                switch (gender)
                {
                    case 'm': monthlyPassPrice = 51; break;
                    case 'f': monthlyPassPrice = 53; break;
                }
            }
            else if (sport == "Pilates")
            {
                switch (gender)
                {
                    case 'm': monthlyPassPrice = 39; break;
                    case 'f': monthlyPassPrice = 37; break;
                }
            }

            if (age <= 19)
            {
                monthlyPassPrice -= monthlyPassPrice * 0.20;
            }

            if (budget >= monthlyPassPrice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${monthlyPassPrice - budget:F2} more.");
            }
        }
    }
}
