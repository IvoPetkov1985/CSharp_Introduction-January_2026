namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursPerProject = 3;

            string architectName = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());
            int hoursNeeded = hoursPerProject * projectsCount;

            Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {projectsCount} project/s.");
        }
    }
}
