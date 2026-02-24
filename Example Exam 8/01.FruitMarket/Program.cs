namespace _01.FruitMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasQuantity = double.Parse(Console.ReadLine());
            double orangesQuantity = double.Parse(Console.ReadLine());
            double raspberriesQuantity = double.Parse(Console.ReadLine());
            double strawberriesQuantity = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesPrice * 0.5;
            double orangesPrice = raspberriesPrice * 0.6;
            double bananasPrice = raspberriesPrice * 0.2;

            double sumStrawberries = strawberriesPrice * strawberriesQuantity;
            double sumRaspberries = raspberriesPrice * raspberriesQuantity;
            double sumOranges = orangesPrice * orangesQuantity;
            double sumBananas = bananasPrice * bananasQuantity;

            double finalSum = sumStrawberries + sumRaspberries + sumOranges + sumBananas;
            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
