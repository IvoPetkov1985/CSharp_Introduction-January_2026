namespace _01.PipesInPool.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poolVolumeInL = int.Parse(Console.ReadLine());
            int firstPipeDebit = int.Parse(Console.ReadLine());
            int secondPipeDebit = int.Parse(Console.ReadLine());
            double hoursAbsence = double.Parse(Console.ReadLine());

            double firstPipeWater = firstPipeDebit * hoursAbsence;
            double secondPipeWater = secondPipeDebit * hoursAbsence;
            double totalWater = firstPipeWater + secondPipeWater;
            double firstPipePercent = firstPipeWater / totalWater * 100;
            double secondPipePercent = secondPipeWater / totalWater * 100;

            if (totalWater <= poolVolumeInL)
            {
                double percentFull = totalWater / poolVolumeInL * 100;
                Console.WriteLine($"The pool is {percentFull:F2}% full. Pipe 1: {firstPipePercent:F2}%. Pipe 2: {secondPipePercent:F2}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursAbsence:F2} hours the pool overflows with {totalWater - poolVolumeInL:F2} liters.");
            }
        }
    }
}
