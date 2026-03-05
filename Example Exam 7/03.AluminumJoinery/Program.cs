namespace _03.AluminumJoinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joineriesCount = int.Parse(Console.ReadLine());
            string productSize = Console.ReadLine();
            string delivery = Console.ReadLine();

            double singlePrice = 0;

            switch (productSize)
            {
                case "90X130":
                    singlePrice = 110;

                    if (joineriesCount > 60)
                    {
                        singlePrice *= 0.92;
                    }
                    else if (joineriesCount > 30)
                    {
                        singlePrice *= 0.95;
                    }

                    break;

                case "100X150":
                    singlePrice = 140;

                    if (joineriesCount > 80)
                    {
                        singlePrice *= 0.90;
                    }
                    else if (joineriesCount > 40)
                    {
                        singlePrice *= 0.94;
                    }

                    break;

                case "130X180":
                    singlePrice = 190;

                    if (joineriesCount > 50)
                    {
                        singlePrice *= 0.88;
                    }
                    else if (joineriesCount > 20)
                    {
                        singlePrice *= 0.93;
                    }

                    break;

                case "200X300":
                    singlePrice = 250;

                    if (joineriesCount > 50)
                    {
                        singlePrice *= 0.86;
                    }
                    else if (joineriesCount > 20)
                    {
                        singlePrice *= 0.91;
                    }

                    break;
            }

            double joineriesSum = joineriesCount * singlePrice;

            if (delivery == "With delivery")
            {
                joineriesSum += 60;
            }

            if (joineriesCount > 99)
            {
                joineriesSum *= 0.96;
            }

            if (joineriesCount >= 10)
            {
                Console.WriteLine($"{joineriesSum:F2} BGN");
            }
            else
            {
                Console.WriteLine("Invalid order");
            }
        }
    }
}
