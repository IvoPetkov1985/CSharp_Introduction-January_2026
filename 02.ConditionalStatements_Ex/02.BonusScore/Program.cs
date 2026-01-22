namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialPoints = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (initialPoints <= 100)
            {
                bonusPoints = 5;
            }
            else if (initialPoints <= 1000)
            {
                bonusPoints = initialPoints * 0.20;
            }
            else
            {
                bonusPoints = initialPoints * 0.10;
            }

            if (initialPoints % 2 == 0)
            {
                bonusPoints++;
            }
            else if (initialPoints % 10 == 5)
            {
                bonusPoints += 2;
            }

            double totalPoints = initialPoints + bonusPoints;
            Console.WriteLine(bonusPoints);
            Console.WriteLine(totalPoints);
        }
    }
}
