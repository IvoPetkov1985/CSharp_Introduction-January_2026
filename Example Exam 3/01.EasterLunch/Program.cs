namespace _01.EasterLunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            int eggsStacks = int.Parse(Console.ReadLine());
            int kilosCookies = int.Parse(Console.ReadLine());

            double easterBreadPrice = 3.20;
            double eggsStackPrice = 4.35;
            double kiloCookiesPrice = 5.40;
            double paintPerEggPrice = 0.15;
            int eggsInStack = 12;

            double sumBreads = easterBreads * easterBreadPrice;
            double sumEggs = eggsStacks * eggsStackPrice;
            double sumCookies = kilosCookies * kiloCookiesPrice;
            double sumPaint = eggsStacks * eggsInStack * paintPerEggPrice;
            double finalSum = sumBreads + sumEggs + sumCookies + sumPaint;

            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
