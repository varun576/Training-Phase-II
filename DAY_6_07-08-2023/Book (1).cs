using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Book
    {

        private readonly int bookId;
        private string? author;
        private bool isAvailable;

        public Book(int bookId, string? title, string? author, bool isAvailable)
        {
            this.bookId = bookId;
            this.Title = title;
            this.author = author;
            this.isAvailable = isAvailable;
        }

        public int BookId => bookId;

        public string? Title { get; set; }
        public string? Author { get => author; set => author = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

        public void DisplayDetails()
        {
            Console.WriteLine($"{BookId} {Title} {Author} {IsAvailable}");
        }

        public static void LendItem(string? title)
        {
            int count = 0;
            foreach (Book i in Library.book)
            {
                if (i.Title.ToLower().Equals(title.ToLower()))
                {
                    i.IsAvailable = false;
                    Console.WriteLine("Book is Borrowed");
                    count++;
                }
            }
            if (count == 0)
            { Console.WriteLine("Book not Available");
            }
        }
    }
}
