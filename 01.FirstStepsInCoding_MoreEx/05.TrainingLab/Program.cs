namespace _05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double roomLengthInM = double.Parse(Console.ReadLine());
            double roomWidthInM = double.Parse(Console.ReadLine());

            double lengthInCm = roomLengthInM * 100;
            double widthInCm = roomWidthInM * 100;
            int missingPlaces = 3;
            int placeWidth = 70;
            int placeLength = 120;

            double widthWithoutPath = widthInCm - 100;
            double placesInRow = Math.Truncate(widthWithoutPath / placeWidth);
            double placesInCol = Math.Truncate(lengthInCm / placeLength);
            double totalPlaces = placesInCol * placesInRow - missingPlaces;
            Console.WriteLine(totalPlaces);
        }
    }
}
