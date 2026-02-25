namespace _05.FitnessCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());

            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int shakes = 0;
            int bars = 0;

            for (int i = 0; i < visitors; i++)
            {
                string activity = Console.ReadLine();

                switch (activity)
                {
                    case "Back": back++; break;
                    case "Chest": chest++; break;
                    case "Legs": legs++; break;
                    case "Abs": abs++; break;
                    case "Protein shake": shakes++; break;
                    case "Protein bar": bars++; break;
                }
            }

            int workingOut = back + chest + legs + abs;
            int proteinBuying = shakes + bars;
            double workOutPercent = workingOut * 100d / visitors;
            double proteinPercent = proteinBuying * 100d / visitors;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{shakes} - protein shake");
            Console.WriteLine($"{bars} - protein bar");
            Console.WriteLine($"{workOutPercent:F2}% - work out");
            Console.WriteLine($"{proteinPercent:F2}% - protein");
        }
    }
}
