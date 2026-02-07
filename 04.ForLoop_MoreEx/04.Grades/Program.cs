namespace _04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            int aboveFive = 0;
            int aboveFour = 0;
            int aboveThree = 0;
            int fail = 0;
            double totalGrade = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5)
                {
                    aboveFive++;
                }
                else if (grade >= 4)
                {
                    aboveFour++;
                }
                else if (grade >= 3)
                {
                    aboveThree++;
                }
                else
                {
                    fail++;
                }

                totalGrade += grade;
            }

            double topStudentsPercent = aboveFive * 100.0 / students;
            double aboveFourPercent = aboveFour * 100.0 / students;
            double aboveThreePercent = aboveThree * 100.0 / students;
            double failPercent = fail * 100.0 / students;
            double averageGrade = totalGrade / students;

            Console.WriteLine($"Top students: {topStudentsPercent:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {aboveFourPercent:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {aboveThreePercent:F2}%");
            Console.WriteLine($"Fail: {failPercent:F2}%");
            Console.WriteLine($"Average: {averageGrade:F2}");
        }
    }
}
