namespace _05.TrainingLab.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double roomLength = double.Parse(Console.ReadLine());
            double roomWidth = double.Parse(Console.ReadLine());

            double roomLengthInCm = roomLength * 100;
            double roomWidthInCm = roomWidth * 100;

            int pathWidth = 100;
            int workplaceWidth = 70;
            int workplaceLength = 120;
            int missingWorkplaces = 3;

            int workplacesInRow = (int)(roomWidthInCm - pathWidth) / workplaceWidth;
            int workplacesInCol = (int)roomLengthInCm / workplaceLength;
            int totalWorkplaces = workplacesInRow * workplacesInCol - missingWorkplaces;
            Console.WriteLine(totalWorkplaces);
        }
    }
}
