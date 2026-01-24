namespace _01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int firstPipeDebitPerHour = int.Parse(Console.ReadLine());
            int secondPipeDebitPerHour = int.Parse(Console.ReadLine());
            double hoursAbsence = double.Parse(Console.ReadLine());

            double firstPipeLiters = firstPipeDebitPerHour * hoursAbsence;
            double secondPipeLiters = secondPipeDebitPerHour * hoursAbsence;
            double totalLiters = firstPipeLiters + secondPipeLiters;
            double firstPipePercentage = firstPipeLiters / totalLiters * 100;
            double secondPipePercentage = secondPipeLiters / totalLiters * 100;
            double totalLitersPercentage = totalLiters / poolVolume * 100;

            if (totalLiters <= poolVolume)
            {
                Console.WriteLine($"The pool is {totalLitersPercentage:f2}% full. Pipe 1: {firstPipePercentage:f2}%. Pipe 2: {secondPipePercentage:f2}%.");
            }
            else
            {
                double overflowLiters = totalLiters - poolVolume;
                Console.WriteLine($"For {hoursAbsence:f2} hours the pool overflows with {overflowLiters:f2} liters.");
            }
        }
    }
}
