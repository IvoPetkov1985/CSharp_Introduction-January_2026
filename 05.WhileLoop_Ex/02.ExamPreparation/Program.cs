namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allowedFails = int.Parse(Console.ReadLine());

            int failsCounter = 0;
            string lastProblemName = string.Empty;
            bool needsBreak = false;
            List<int> grades = new();

            while (true)
            {
                string problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                grades.Add(grade);
                lastProblemName = problemName;

                if (grade <= 4)
                {
                    failsCounter++;
                }

                if (failsCounter == allowedFails)
                {
                    needsBreak = true;
                    break;
                }
            }

            if (!needsBreak)
            {
                double averageScore = grades.Average();
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {grades.Count}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }
            else
            {
                Console.WriteLine($"You need a break, {failsCounter} poor grades.");
            }
        }
    }
}
