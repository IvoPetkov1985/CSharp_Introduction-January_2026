namespace _07.ProjectsCreation.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursPerProject = 3;

            string inputName = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {inputName} will need {hoursPerProject * projectsCount} hours to complete {projectsCount} project/s.");
        }
    }
}
