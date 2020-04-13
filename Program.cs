using System;
using System.Collections.Generic;

namespace Simple_Bookshelf_Sorter
{
    class UserInput
    {
        public SortedDictionary<string, string> bookShelf = new SortedDictionary<string, string>();
        public string bookTitle;
        public string bookAuthor;
        public string choice;
    }
    class Program
    {
        static void Main(string[] args)
        {
            UserInput usript = new UserInput();

            Console.WriteLine("Welcome to the Simple Bookshelf Sorter application.");
            Console.WriteLine("Let's add a book to your shelf.");

            Console.WriteLine("What's the book's title?");
            usript.bookTitle = Console.ReadLine();

            Console.WriteLine("Who's the book's author?");
            usript.bookAuthor = Console.ReadLine();

            usript.bookShelf.Add(usript.bookTitle, usript.bookAuthor);

            Console.WriteLine("You now have one book in your bookshelf: {0}, by {1}", usript.bookTitle, usript.bookAuthor);

            bool addBook = true;

            while (addBook)
            {
                Console.WriteLine("Enter y if you Would you like to add another book or any other key to finish your bookshelf:");
                usript.choice = Console.ReadLine();

                if (usript.choice == "y")
                {
                    Console.WriteLine("What's the book's title?");
                    usript.bookTitle = Console.ReadLine();

                    Console.WriteLine("Who's the book's author?");
                    usript.bookAuthor = Console.ReadLine();

                    usript.bookShelf.Add(usript.bookTitle, usript.bookAuthor);
                }
                else
                {
                    addBook = false;
                }

                Console.WriteLine("Your bookshelf now has the books:");

                foreach (KeyValuePair<string, string> book in usript.bookShelf)
                {
                    Console.WriteLine("{0}, by {1}", book.Key, book.Value);
                }
            }
        }
    }
}