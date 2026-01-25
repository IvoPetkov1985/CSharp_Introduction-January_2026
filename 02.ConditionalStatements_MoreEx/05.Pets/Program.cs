namespace _05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysAbsence = int.Parse(Console.ReadLine());
            double foodInKg = double.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse((Console.ReadLine()));
            double tortoiseFoodPerDayInG = double.Parse((Console.ReadLine()));

            double tortoiseFoodPerDay = tortoiseFoodPerDayInG / 1000;
            double neededFoodInKg = dogFoodPerDay * daysAbsence +
                catFoodPerDay * daysAbsence +
                tortoiseFoodPerDay * daysAbsence;

            if (foodInKg >= neededFoodInKg)
            {
                Console.WriteLine($"{Math.Floor(foodInKg - neededFoodInKg)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(neededFoodInKg - foodInKg)} more kilos of food are needed.");
            }
        }
    }
}
