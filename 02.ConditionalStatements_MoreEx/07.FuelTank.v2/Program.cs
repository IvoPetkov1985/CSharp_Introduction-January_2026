namespace _07.FuelTank.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            bool isFuelEnough = quantity >= 25;

            switch (fuelType)
            {
                case "Diesel":

                    if (isFuelEnough)
                    {
                        Console.WriteLine("You have enough diesel.");
                    }
                    else
                    {
                        Console.WriteLine("Fill your tank with diesel!");
                    }

                    break;

                case "Gasoline":

                    if (isFuelEnough)
                    {
                        Console.WriteLine("You have enough gasoline.");
                    }
                    else
                    {
                        Console.WriteLine("Fill your tank with gasoline!");
                    }

                    break;

                case "Gas":

                    if (isFuelEnough)
                    {
                        Console.WriteLine("You have enough gas.");
                    }
                    else
                    {
                        Console.WriteLine("Fill your tank with gas!");
                    }

                    break;

                default:

                    Console.WriteLine("Invalid fuel!");

                    break;
            }
        }
    }
}
