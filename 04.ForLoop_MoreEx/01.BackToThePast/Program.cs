namespace _01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());

            int startYear = 1800;
            int age = 18;
            double expenses = 0;
            double expensesPerYear = 12000;

            for (int year = startYear; year <= endYear; year++)
            {
                if (year % 2 == 0)
                {
                    expenses += expensesPerYear;
                }
                else
                {
                    expenses += expensesPerYear + 50 * age;
                }

                age++;
            }

            double diff = Math.Abs(money - expenses);

            if (money >= expenses)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {diff:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {diff:F2} dollars to survive.");
            }
        }
    }
}
