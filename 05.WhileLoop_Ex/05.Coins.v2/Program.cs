namespace _05.Coins.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int sumInCents = (int)(sum * 100);
            int coinsReturned = 0;

            while (true)
            {
                if (sumInCents >= 200)
                {
                    sumInCents -= 200;
                }
                else if (sumInCents >= 100)
                {
                    sumInCents -= 100;
                }
                else if (sumInCents >= 50)
                {
                    sumInCents -= 50;
                }
                else if (sumInCents >= 20)
                {
                    sumInCents -= 20;
                }
                else if (sumInCents >= 10)
                {
                    sumInCents -= 10;
                }
                else if (sumInCents >= 5)
                {
                    sumInCents -= 5;
                }
                else if (sumInCents >= 2)
                {
                    sumInCents -= 2;
                }
                else if (sumInCents >= 1)
                {
                    sumInCents -= 1;
                }

                coinsReturned++;

                if (sumInCents == 0)
                {
                    break;
                }
            }

            Console.WriteLine(coinsReturned);
        }
    }
}
