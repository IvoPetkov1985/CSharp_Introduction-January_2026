namespace _05.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int length = text.Length;

            for (int i = 0; i < length; i++)
            {
                char symbol = text[i];
                Console.WriteLine(symbol);
            }
        }
    }
}
