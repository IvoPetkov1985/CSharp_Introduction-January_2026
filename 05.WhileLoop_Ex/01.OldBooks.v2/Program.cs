namespace _01.OldBooks.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();

            int bookCounter = 0;
            string currentBook = Console.ReadLine();
            bool isFound = false;

            while (currentBook != "No More Books")
            {
                if (currentBook == searchedBook)
                {
                    isFound = true;
                    break;
                }

                bookCounter++;
                currentBook = Console.ReadLine();
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
        }
    }
}
