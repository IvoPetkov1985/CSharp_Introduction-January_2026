namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double realMoney = double.Parse(Console.ReadLine());

            int totalDays = 0;
            int spendingDays = 0;
            bool succeeded = true;

            while (true)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                totalDays++;

                if (action == "spend")
                {
                    spendingDays++;
                    realMoney -= amount;

                    if (realMoney < 0)
                    {
                        realMoney = 0;
                    }

                    if (spendingDays == 5)
                    {
                        succeeded = false;
                        break;
                    }
                }
                else if (action == "save")
                {
                    spendingDays = 0;
                    realMoney += amount;

                    if (realMoney >= tripPrice)
                    {
                        break;
                    }
                }
            }

            if (succeeded == false)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(totalDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
        }
    }
}
