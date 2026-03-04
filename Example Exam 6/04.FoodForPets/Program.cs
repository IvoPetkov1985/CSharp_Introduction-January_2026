namespace _04.FoodForPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double bisquits = 0;
            int eatenByDog = 0;
            int eatenByCat = 0;

            for (int day = 1; day <= days; day++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());
                eatenByDog += dogFood;
                eatenByCat += catFood;

                if (day % 3 == 0)
                {
                    int dayFood = dogFood + catFood;
                    bisquits += dayFood * 0.1;
                }
            }

            int totalEaten = eatenByDog + eatenByCat;
            double percentEaten = totalEaten * 100d / food;
            double dogFoodPercent = eatenByDog * 100d / totalEaten;
            double catFoodPercnet = eatenByCat * 100d / totalEaten;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(bisquits)}gr.");
            Console.WriteLine($"{percentEaten:F2}% of the food has been eaten.");
            Console.WriteLine($"{dogFoodPercent:F2}% eaten from the dog.");
            Console.WriteLine($"{catFoodPercnet:F2}% eaten from the cat.");
        }
    }
}
