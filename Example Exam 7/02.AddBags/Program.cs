namespace _02.AddBags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double luggageTax = double.Parse(Console.ReadLine());
            double kilosLuggage = double.Parse(Console.ReadLine());
            int daysCount = int.Parse(Console.ReadLine());
            int luggagesCount = int.Parse(Console.ReadLine());

            if (kilosLuggage < 10)
            {
                luggageTax *= 0.2;
            }
            else if (kilosLuggage <= 20)
            {
                luggageTax *= 0.5;
            }

            if (daysCount < 7)
            {
                luggageTax *= 1.40;
            }
            else if (daysCount <= 30)
            {
                luggageTax *= 1.15;
            }
            else
            {
                luggageTax *= 1.10;
            }

            double bagsPrice = luggageTax * luggagesCount;
            Console.WriteLine($"The total price of bags is: {bagsPrice:F2} lv.");
        }
    }
}
