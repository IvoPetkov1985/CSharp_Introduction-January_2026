namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePerSqMeter = 7.61;
            double discount = 0.18;

            double sqMetersToBeGreened = double.Parse(Console.ReadLine());

            double totalCost = sqMetersToBeGreened * pricePerSqMeter;
            double discountCost = totalCost * discount;
            double payCost = totalCost - discountCost;

            Console.WriteLine($"The final price is: {payCost} lv.");
            Console.WriteLine($"The discount is: {discountCost} lv.");
        }
    }
}
