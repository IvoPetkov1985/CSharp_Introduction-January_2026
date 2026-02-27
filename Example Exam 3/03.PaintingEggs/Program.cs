namespace _03.PaintingEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string eggsColor = Console.ReadLine();
            int eggsStacks = int.Parse(Console.ReadLine());

            int eggStackPrice = 0;
            int expensesPercent = 35;

            if (eggsSize == "Large")
            {
                if (eggsColor == "Red")
                {
                    eggStackPrice = 16;
                }
                else if (eggsColor == "Green")
                {
                    eggStackPrice = 12;
                }
                else if (eggsColor == "Yellow")
                {
                    eggStackPrice = 9;
                }
            }
            else if (eggsSize == "Medium")
            {
                if (eggsColor == "Red")
                {
                    eggStackPrice = 13;
                }
                else if (eggsColor == "Green")
                {
                    eggStackPrice = 9;
                }
                else if (eggsColor == "Yellow")
                {
                    eggStackPrice = 7;
                }
            }
            else if (eggsSize == "Small")
            {
                if (eggsColor == "Red")
                {
                    eggStackPrice = 9;
                }
                else if (eggsColor == "Green")
                {
                    eggStackPrice = 8;
                }
                else if (eggsColor == "Yellow")
                {
                    eggStackPrice = 5;
                }
            }

            int totalPrice = eggsStacks * eggStackPrice;
            double profit = totalPrice - totalPrice * expensesPercent / 100d;
            Console.WriteLine($"{profit:F2} leva.");
        }
    }
}
