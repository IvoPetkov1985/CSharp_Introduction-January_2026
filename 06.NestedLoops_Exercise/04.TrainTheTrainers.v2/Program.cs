namespace _04.TrainTheTrainers.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());

            double sumAssessments = 0;
            int totalGradesCount = 0;

            while (true)
            {
                string presentation = Console.ReadLine();

                if (presentation == "Finish")
                {
                    break;
                }

                double currentGrades = 0;

                for (int assessment = 1; assessment <= juryCount; assessment++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    currentGrades += grade;
                }

                double presentationAssessment = currentGrades / juryCount;
                sumAssessments += currentGrades;
                totalGradesCount += juryCount;
                Console.WriteLine($"{presentation} - {presentationAssessment:F2}.");
            }

            double finalAssessment = sumAssessments / totalGradesCount;
            Console.WriteLine($"Student's final assessment is {finalAssessment:F2}.");
        }
    }
}
