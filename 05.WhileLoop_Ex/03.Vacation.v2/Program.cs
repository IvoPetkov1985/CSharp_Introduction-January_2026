namespace _03.Vacation.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spendDaysInRow = 0;

            while (spendDaysInRow < 5 && ownedMoney < tripPrice)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                daysCount++;

                switch (action)
                {
                    case "spend":
                        spendDaysInRow++;
                        ownedMoney -= amount;

                        if (ownedMoney < 0)
                        {
                            ownedMoney = 0;
                        }

                        break;

                    case "save":
                        spendDaysInRow = 0;
                        ownedMoney += amount;
                        break;
                }
            }

            if (spendDaysInRow == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCount);
            }

            if (ownedMoney >= tripPrice)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
