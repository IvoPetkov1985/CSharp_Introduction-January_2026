namespace _06.BarcodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startingBarcode = Console.ReadLine();
            string endingBarcode = Console.ReadLine();

            int startFirstDigit = int.Parse(startingBarcode[0].ToString());
            int startSecondDigit = int.Parse(startingBarcode[1].ToString());
            int startThirdDigit = int.Parse(startingBarcode[2].ToString());
            int startForthDigit = int.Parse(startingBarcode[3].ToString());

            int endFirstDigit = int.Parse(endingBarcode[0].ToString());
            int endSecondDigit = int.Parse(endingBarcode[1].ToString());
            int endThirdDigit = int.Parse(endingBarcode[2].ToString());
            int endForthDigit = int.Parse(endingBarcode[3].ToString());

            List<int> barcodesWithOddDigits = new();

            for (int x1 = startFirstDigit; x1 <= endFirstDigit; x1++)
            {
                if (x1 % 2 == 1)
                {
                    for (int x2 = startSecondDigit; x2 <= endSecondDigit; x2++)
                    {
                        if (x2 % 2 == 1)
                        {
                            for (int x3 = startThirdDigit; x3 <= endThirdDigit; x3++)
                            {
                                if (x3 % 2 == 1)
                                {
                                    for (int x4 = startForthDigit; x4 <= endForthDigit; x4++)
                                    {
                                        if (x4 % 2 == 1)
                                        {
                                            barcodesWithOddDigits.Add(int.Parse($"{x1}{x2}{x3}{x4}"));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", barcodesWithOddDigits));
        }
    }
}
