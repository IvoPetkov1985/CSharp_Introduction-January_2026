namespace _04.FoodForPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());

            double bisquits = 0;
            double dogEaten = 0;
            double catEaten = 0;

            for (int day = 1; day <= days; day++)
            {
                double dogFood = double.Parse(Console.ReadLine());
                double catFood = double.Parse(Console.ReadLine());

                if (day % 3 == 0)
                {
                    bisquits += (dogFood + catFood) * 0.1;
                }

                dogEaten += dogFood;
                catEaten += catFood;
            }

            double totalEaten = dogEaten + catEaten;
            double percentEatenFood = totalEaten * 100 / totalFood;
            double percentDogEaten = dogEaten * 100 / totalEaten;
            double percentCatEaten = catEaten * 100 / totalEaten;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(bisquits, 0)}gr.");
            Console.WriteLine($"{percentEatenFood:F2}% of the food has been eaten.");
            Console.WriteLine($"{percentDogEaten:F2}% eaten from the dog.");
            Console.WriteLine($"{percentCatEaten:F2}% eaten from the cat.");
        }
    }
}
