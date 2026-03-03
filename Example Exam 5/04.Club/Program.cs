namespace _04.Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());
            double tonightIncome = 0;

            while (true)
            {
                string cocktail = Console.ReadLine();

                if (cocktail == "Party!")
                {
                    Console.WriteLine($"We need {desiredProfit - tonightIncome:F2} leva more.");
                    break;
                }

                int price = cocktail.Length;
                int quantity = int.Parse(Console.ReadLine());
                double bill = price * quantity;

                if (bill % 2 != 0)
                {
                    bill -= bill * 0.25;
                }

                tonightIncome += bill;

                if (tonightIncome >= desiredProfit)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
            }

            Console.WriteLine($"Club income - {tonightIncome:F2} leva.");
        }
    }
}
