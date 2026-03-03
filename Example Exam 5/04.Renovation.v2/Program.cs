namespace _04.Renovation.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wallHeight = int.Parse(Console.ReadLine());
            int wallWidth = int.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());

            int wallsArea = wallHeight * wallWidth * 4;
            double doorsAndWindows = wallsArea * percentage / 100d;
            int areaToPaint = (int)Math.Ceiling(wallsArea - doorsAndWindows);
            int totalPaint = 0;
            string command = Console.ReadLine();

            while (command != "Tired!")
            {
                int paint = int.Parse(command);
                totalPaint += paint;

                if (totalPaint == areaToPaint)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }
                else if (totalPaint > areaToPaint)
                {
                    Console.WriteLine($"All walls are painted and you have {totalPaint - areaToPaint} l paint left!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "Tired!")
            {
                Console.WriteLine($"{areaToPaint - totalPaint} quadratic m left.");
            }
        }
    }
}
