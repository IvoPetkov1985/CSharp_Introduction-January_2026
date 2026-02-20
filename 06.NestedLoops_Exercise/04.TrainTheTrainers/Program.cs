namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string subject = Console.ReadLine();

            int allGradesCount = 0;
            double sumAllGrades = 0;

            while (subject != "Finish")
            {
                double subjectGrades = 0;

                for (int i = 1; i <= juryCount; i++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    subjectGrades += currentGrade;
                }

                double subjectAverageGrade = subjectGrades / juryCount;
                Console.WriteLine($"{subject} - {subjectAverageGrade:F2}.");

                allGradesCount += juryCount;
                sumAllGrades += subjectGrades;

                subject = Console.ReadLine();
            }

            double finalAverageGrade = sumAllGrades / allGradesCount;
            Console.WriteLine($"Student's final assessment is {finalAverageGrade:F2}.");
        }
    }
}
