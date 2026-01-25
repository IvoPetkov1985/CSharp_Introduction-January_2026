namespace _05.Pets.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysAbsence = int.Parse(Console.ReadLine());
            int foodAtHomeInKg = int.Parse(Console.ReadLine());
            double eatenByDogInKg = double.Parse(Console.ReadLine());
            double eatenByCatInKg = double.Parse(Console.ReadLine());
            double eatenByTortoiseInG = double.Parse(Console.ReadLine());

            double eatenByTortoiseInKg = eatenByTortoiseInG * 0.001;
            double totalEatenInKg = (eatenByDogInKg + eatenByCatInKg + eatenByTortoiseInKg) * daysAbsence;
            double foodDiff = Math.Abs(foodAtHomeInKg - totalEatenInKg);

            if (foodAtHomeInKg >= totalEatenInKg)
            {
                Console.WriteLine($"{Math.Floor(foodDiff)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodDiff)} more kilos of food are needed.");
            }
        }
    }
}
