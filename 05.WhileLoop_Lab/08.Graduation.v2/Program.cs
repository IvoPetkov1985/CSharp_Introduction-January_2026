namespace _08.Graduation.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int failed = 0;
            List<double> marks = new();

            while (marks.Count < 12)
            {
                double yearMark = double.Parse(Console.ReadLine());

                if (yearMark >= 4.00)
                {
                    marks.Add(yearMark);
                }
                else
                {
                    failed++;

                    if (failed > 1)
                    {
                        break;
                    }
                }
            }

            if (marks.Count == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {marks.Average():F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {marks.Count + 1} grade");
            }
        }
    }
}
