namespace _01.CatDiet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fatsPercent = int.Parse(Console.ReadLine());
            int proteinsPercent = int.Parse(Console.ReadLine());
            int carbohydratesPercent = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int waterPercent = int.Parse(Console.ReadLine());

            double fatsInGrams = fatsPercent * totalCalories / 100d / 9;
            double proteinsInGrams = proteinsPercent * totalCalories / 100d / 4;
            double carbohydratesInGrams = carbohydratesPercent * totalCalories / 100d / 4;
            double foodInGrams = fatsInGrams + proteinsInGrams + carbohydratesInGrams;
            double caloriesPerGramFood = totalCalories / foodInGrams;
            double caloriesInWater = waterPercent * caloriesPerGramFood / 100d;
            double caloriesInGramDryFood = caloriesPerGramFood - caloriesInWater;

            Console.WriteLine($"{caloriesInGramDryFood:F4}");
        }
    }
}
