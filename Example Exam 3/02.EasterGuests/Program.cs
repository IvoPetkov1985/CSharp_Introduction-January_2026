namespace _02.EasterGuests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double easterBreadPrice = 4.00;
            double eggPrice = 0.45;

            int eggsNeeded = guests * 2;
            double sumEggs = eggPrice * eggsNeeded;
            double easterBreadsNeeded = Math.Ceiling(guests / 3d);
            double sumEasterBreads = easterBreadPrice * easterBreadsNeeded;
            double finalSum = sumEggs + sumEasterBreads;

            if (budget >= finalSum)
            {
                Console.WriteLine($"Lyubo bought {easterBreadsNeeded} Easter bread and {eggsNeeded} eggs.");
                Console.WriteLine($"He has {budget - finalSum:F2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {finalSum - budget:F2} lv. more.");
            }
        }
    }
}
