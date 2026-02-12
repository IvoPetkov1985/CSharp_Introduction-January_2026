namespace _02.ExamPreparation.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allowedFails = int.Parse(Console.ReadLine());

            int totalGrade = 0;
            int failsCounter = 0;
            int problemsSolved = 0;
            bool needsBreak = false;
            string lastProblem = string.Empty;
            string problemName = Console.ReadLine();

            while (problemName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                totalGrade += grade;
                problemsSolved++;
                lastProblem = problemName;

                if (grade <= 4)
                {
                    failsCounter++;
                }

                if (failsCounter == allowedFails)
                {
                    needsBreak = true;
                    break;
                }

                problemName = Console.ReadLine();
            }

            if (needsBreak == false)
            {
                double averageScore = (double)totalGrade / problemsSolved;
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {problemsSolved}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {failsCounter} poor grades.");
            }
        }
    }
}
