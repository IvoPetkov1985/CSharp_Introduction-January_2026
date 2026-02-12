namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();

            int checkedBooks = 0;

            while (true)
            {
                string currentBook = Console.ReadLine();

                if (currentBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkedBooks} books.");
                    break;
                }

                if (currentBook == searchedBook)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }

                checkedBooks++;
            }
        }
    }
}
