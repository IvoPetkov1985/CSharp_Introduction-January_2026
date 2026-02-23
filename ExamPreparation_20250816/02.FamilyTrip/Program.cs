namespace _02.FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int percentExpenses = int.Parse(Console.ReadLine());

            double sumForNights = nightsCount * pricePerNight;

            if (nightsCount > 7)
            {
                sumForNights *= 0.95;
            }

            double sumForExpenses = budget * percentExpenses / 100;
            double totalSum = sumForNights + sumForExpenses;

            if (budget >= totalSum)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalSum:F2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalSum - budget:F2} leva needed.");
            }
        }
    }
}
