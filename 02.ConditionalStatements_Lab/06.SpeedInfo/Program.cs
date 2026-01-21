namespace _06.SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            string info = string.Empty;

            if (speed <= 10)
            {
                info = "slow";
            }
            else if (speed <= 50)
            {
                info = "average";
            }
            else if (speed <= 150)
            {
                info = "fast";
            }
            else if (speed <= 1000)
            {
                info = "ultra fast";
            }
            else if (speed > 1000)
            {
                info = "extremely fast";
            }

            Console.WriteLine(info);
        }
    }
}
