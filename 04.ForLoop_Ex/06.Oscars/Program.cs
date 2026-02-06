namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int juryCount = int.Parse(Console.ReadLine());

            double neededPoints = 1250.5;

            for (int i = 0; i < juryCount; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());
                double assessment = juryName.Length * juryPoints / 2;
                academyPoints += assessment;

                if (academyPoints > neededPoints)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:F1}!");
                    break;
                }
            }

            if (academyPoints <= neededPoints)
            {
                Console.WriteLine($"Sorry, {actorName} you need {neededPoints - academyPoints:F1} more!");
            }
        }
    }
}
