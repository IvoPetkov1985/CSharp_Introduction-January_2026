namespace _02.FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double familyBudget = double.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int additionalExpensesPercent = int.Parse(Console.ReadLine());
            int discountPercent = 5;

            if (nightsCount > 7)
            {
                pricePerNight -= pricePerNight * discountPercent / 100d;
            }

            double additionalExpensesPrice = familyBudget * additionalExpensesPercent / 100d;
            double sumNights = pricePerNight * nightsCount;
            double tripPrice = sumNights + additionalExpensesPrice;

            if (familyBudget >= tripPrice)
            {
                Console.WriteLine($"Ivanovi will be left with {familyBudget - tripPrice:F2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{tripPrice - familyBudget:F2} leva needed.");
            }
        }
    }
}
