namespace _07.FuelTank.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFuel = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            int enoughFuelQuantity = 25;

            if (inputFuel == "Diesel")
            {
                if (quantity >= enoughFuelQuantity)
                {
                    Console.WriteLine("You have enough diesel.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
            }
            else if (inputFuel == "Gasoline")
            {
                if (quantity >= enoughFuelQuantity)
                {
                    Console.WriteLine("You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with gasoline!");
                }
            }
            else if (inputFuel == "Gas")
            {
                if (quantity >= enoughFuelQuantity)
                {
                    Console.WriteLine("You have enough gas.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with gas!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
