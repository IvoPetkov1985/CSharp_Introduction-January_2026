namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            double sumGrades = 0;
            int studyClass = 1;
            int failedTimes = 0;
            bool graduated = false;

            while (true)
            {
                double yearGrade = double.Parse(Console.ReadLine());

                if (yearGrade >= 4)
                {
                    studyClass++;
                    sumGrades += yearGrade;
                }
                else
                {
                    failedTimes++;
                }

                if (failedTimes > 1)
                {
                    break;
                }

                if (studyClass > 12)
                {
                    graduated = true;
                    break;
                }
            }

            if (graduated)
            {
                double averageGrade = sumGrades / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
            }
            else
            {
                Console.WriteLine($"{studentName} has been excluded at {studyClass} grade");
            }
        }
    }
}
