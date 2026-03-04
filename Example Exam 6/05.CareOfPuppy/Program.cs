namespace _05.CareOfPuppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int purchasedFoodInKg = int.Parse(Console.ReadLine());
            int neededFood = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Adopted")
                {
                    break;
                }

                int dayFood = int.Parse(command);
                neededFood += dayFood;
            }

            int purchasedFoodInG = purchasedFoodInKg * 1000;

            if (neededFood <= purchasedFoodInG)
            {
                Console.WriteLine($"Food is enough! Leftovers: {purchasedFoodInG - neededFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {neededFood - purchasedFoodInG} grams more.");
            }
        }
    }
}
