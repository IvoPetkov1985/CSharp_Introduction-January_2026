namespace _02.CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int walksCount = int.Parse(Console.ReadLine());
            int receivedCalories = int.Parse(Console.ReadLine());
            int exhaustedCaloriesPerMinute = 5;

            int totalWalkInMinutes = minutesWalk * walksCount;
            int totalCalories = totalWalkInMinutes * exhaustedCaloriesPerMinute;
            double caloriesToBurn = receivedCalories / 2d;

            if (totalCalories >= caloriesToBurn)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCalories}.");
            }
        }
    }
}
