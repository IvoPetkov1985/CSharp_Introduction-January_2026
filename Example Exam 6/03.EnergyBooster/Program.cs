namespace _03.EnergyBooster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int setsCount = int.Parse(Console.ReadLine());
            int smallPackageGels = 2;
            int bigPackageGels = 5;

            double gelPrice = 0;

            if (fruit == "Watermelon")
            {
                switch (size)
                {
                    case "small": gelPrice = 56.00; break;
                    case "big": gelPrice = 28.70; break;
                }
            }
            else if (fruit == "Mango")
            {
                switch (size)
                {
                    case "small": gelPrice = 36.66; break;
                    case "big": gelPrice = 19.60; break;
                }
            }
            else if (fruit == "Pineapple")
            {
                switch (size)
                {
                    case "small": gelPrice = 42.10; break;
                    case "big": gelPrice = 24.80; break;
                }
            }
            else if (fruit == "Raspberry")
            {
                switch (size)
                {
                    case "small": gelPrice = 20.00; break;
                    case "big": gelPrice = 15.20; break;
                }
            }

            double setPrice = 0;

            if (size == "small")
            {
                setPrice = gelPrice * smallPackageGels;
            }
            else
            {
                setPrice = gelPrice * bigPackageGels;
            }

            double totalSum = setPrice * setsCount;

            if (totalSum > 1000)
            {
                totalSum *= 0.5;
            }
            else if (totalSum >= 400)
            {
                totalSum *= 0.85;
            }

            Console.WriteLine($"{totalSum:F2} lv.");
        }
    }
}
