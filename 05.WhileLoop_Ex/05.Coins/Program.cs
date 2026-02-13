namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            int moneyInCents = (int)(money * 100);
            int coins = 0;

            while (moneyInCents > 0)
            {
                if (moneyInCents >= 200)
                {
                    moneyInCents -= 200;
                }
                else if (moneyInCents >= 100)
                {
                    moneyInCents -= 100;
                }
                else if (moneyInCents >= 50)
                {
                    moneyInCents -= 50;
                }
                else if (moneyInCents >= 20)
                {
                    moneyInCents -= 20;
                }
                else if (moneyInCents >= 10)
                {
                    moneyInCents -= 10;
                }
                else if (moneyInCents >= 5)
                {
                    moneyInCents -= 5;
                }
                else if (moneyInCents >= 2)
                {
                    moneyInCents -= 2;
                }
                else
                {
                    moneyInCents -= 1;
                }

                coins++;
            }

            Console.WriteLine(coins);
        }
    }
}
