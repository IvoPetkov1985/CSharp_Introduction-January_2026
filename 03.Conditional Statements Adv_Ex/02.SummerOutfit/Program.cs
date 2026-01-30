namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            string outfit = string.Empty;
            string shoes = string.Empty;

            switch (partOfDay)
            {
                case "Morning":

                    if (degrees <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees > 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }

                    break;

                case "Afternoon":

                    if (degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (degrees > 24)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }

                    break;

                case "Evening":

                    outfit = "Shirt";
                    shoes = "Moccasins";

                    break;
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
