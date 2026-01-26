namespace _07.FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fuelTypes = { "Diesel", "Gasoline", "Gas" };

            string fuel = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (fuelTypes.Contains(fuel))
            {
                if (quantity >= 25)
                {
                    Console.WriteLine($"You have enough {fuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
