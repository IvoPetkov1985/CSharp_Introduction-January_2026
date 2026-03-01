namespace _03.FinalCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = Console.ReadLine();

            double sum = dancers * points;

            if (destination == "Abroad")
            {
                sum *= 1.5;
            }

            int expensesPercent = 0;

            if (destination == "Bulgaria")
            {
                switch (season)
                {
                    case "summer": expensesPercent = 5; break;
                    case "winter": expensesPercent = 8; break;
                }
            }
            else if (destination == "Abroad")
            {
                switch (season)
                {
                    case "summer": expensesPercent = 10; break;
                    case "winter": expensesPercent = 15; break;
                }
            }

            double expenses = sum * expensesPercent / 100;
            double nettoSum = sum - expenses;
            double charitySum = nettoSum * 0.75;
            double sumPerDancer = (nettoSum - charitySum) / dancers;

            Console.WriteLine($"Charity - {charitySum:F2}");
            Console.WriteLine($"Money per dancer - {sumPerDancer:F2}");
        }
    }
}
