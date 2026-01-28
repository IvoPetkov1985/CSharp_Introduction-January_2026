namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;
            bool isCityValid = true;

            switch (city)
            {
                case "Sofia":

                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 7;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 8;
                    }
                    else if (sales > 10000)
                    {
                        commission = 12;
                    }

                    break;

                case "Plovdiv":

                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 5.5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 8;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 12;
                    }
                    else if (sales > 10000)
                    {
                        commission = 14.5;
                    }

                    break;

                case "Varna":

                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 4.5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 7.5;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 10;
                    }
                    else if (sales > 10000)
                    {
                        commission = 13;
                    }

                    break;

                default:
                    isCityValid = false;
                    break;
            }

            if (isCityValid && sales >= 0)
            {
                double tradeCommission = sales * commission / 100;
                Console.WriteLine($"{tradeCommission:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
