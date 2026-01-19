namespace _07.HousePainting.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double houseHeight = double.Parse(Console.ReadLine());
            double sideWallLength = double.Parse(Console.ReadLine());
            double roofTriangleHeight = double.Parse(Console.ReadLine());

            double greenPaintPerLiter = 3.4;
            double redPaintPerLiter = 4.3;

            double doorInSqM = 1.2 * 2;
            double windowsInSqM = Math.Pow(1.5, 2) * 2;
            double notForPaint = doorInSqM + windowsInSqM;

            double smallWalls = Math.Pow(houseHeight, 2) * 2;
            double sideWalls = houseHeight * sideWallLength * 2;
            double wallsArea = smallWalls + sideWalls - notForPaint;
            double greenPaintNeeded = wallsArea / greenPaintPerLiter;

            double roofTriangles = houseHeight * roofTriangleHeight;
            double roofRectangles = houseHeight * sideWallLength * 2;
            double roofArea = roofTriangles + roofRectangles;
            double redPaintNeeded = roofArea / redPaintPerLiter;

            Console.WriteLine($"{greenPaintNeeded:f2}");
            Console.WriteLine($"{redPaintNeeded:f2}");
        }
    }
}
