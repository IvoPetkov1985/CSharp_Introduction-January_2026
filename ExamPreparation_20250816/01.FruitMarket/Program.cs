namespace _01.FruitMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasInKg = double.Parse(Console.ReadLine());
            double orangesInKg = double.Parse(Console.ReadLine());
            double raspberriesInKg = double.Parse(Console.ReadLine());
            double strawberriesInKg = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesPrice / 2;
            double orangesPrice = raspberriesPrice * (1 - 0.40);
            double bananasPrice = raspberriesPrice * (1 - 0.80);

            double totalSum = strawberriesInKg * strawberriesPrice +
                bananasInKg * bananasPrice +
                orangesInKg * orangesPrice +
                raspberriesInKg * raspberriesPrice;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
