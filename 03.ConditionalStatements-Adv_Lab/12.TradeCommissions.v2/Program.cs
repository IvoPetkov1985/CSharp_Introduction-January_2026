namespace _12.TradeCommissions.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            bool isCityValid = true;
            bool areSalesValid = true;
            double multiplyer = 0;

            if (sales < 0)
            {
                areSalesValid = false;
            }

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    multiplyer = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    multiplyer = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    multiplyer = 0.08;
                }
                else if (sales > 10000)
                {
                    multiplyer = 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    multiplyer = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    multiplyer = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    multiplyer = 0.10;
                }
                else if (sales > 10000)
                {
                    multiplyer = 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    multiplyer = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    multiplyer = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    multiplyer = 0.12;
                }
                else if (sales > 10000)
                {
                    multiplyer = 0.145;
                }
            }
            else
            {
                isCityValid = false;
            }

            if (!areSalesValid || !isCityValid)
            {
                Console.WriteLine("error");
            }
            else
            {
                double tradeCommission = sales * multiplyer;
                Console.WriteLine("{0:F2}", tradeCommission);
            }
        }
    }
}
