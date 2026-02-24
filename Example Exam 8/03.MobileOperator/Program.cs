namespace _03.MobileOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string period = Console.ReadLine();
            string type = Console.ReadLine();
            string mobileNet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double sumPerMonth = 0;

            switch (type)
            {
                case "Small":

                    if (period == "one")
                    {
                        sumPerMonth = 9.98;
                    }
                    else if (period == "two")
                    {
                        sumPerMonth = 8.58;
                    }

                    break;

                case "Middle":

                    if (period == "one")
                    {
                        sumPerMonth = 18.99;
                    }
                    else if (period == "two")
                    {
                        sumPerMonth = 17.09;
                    }

                    break;

                case "Large":

                    if (period == "one")
                    {
                        sumPerMonth = 25.98;
                    }
                    else if (period == "two")
                    {
                        sumPerMonth = 23.59;
                    }

                    break;

                case "ExtraLarge":

                    if (period == "one")
                    {
                        sumPerMonth = 35.99;
                    }
                    else if (period == "two")
                    {
                        sumPerMonth = 31.79;
                    }

                    break;
            }

            if (mobileNet == "yes")
            {
                if (sumPerMonth <= 10)
                {
                    sumPerMonth += 5.50;
                }
                else if (sumPerMonth <= 30)
                {
                    sumPerMonth += 4.35;
                }
                else
                {
                    sumPerMonth += 3.85;
                }
            }

            double totalSum = sumPerMonth * months;

            if (period == "two")
            {
                totalSum *= 1 - 3.75 / 100;
            }

            Console.WriteLine($"{totalSum:F2} lv.");
        }
    }
}
