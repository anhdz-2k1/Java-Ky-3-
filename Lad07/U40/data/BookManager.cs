using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U40.data
{
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Valpate", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter", CoverImage = "Assets/2.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Assets/3.png" });
            books.Add(new Book { BookId = 4, Title = "Elip", Author = "Tempor", CoverImage = "Assets/4.png" });
            books.Add(new Book { BookId = 5, Title = "Elip", Author = "Tempor", CoverImage = "Assets/5.png" });
            books.Add(new Book { BookId = 7, Title = "Elip", Author = "Tempor", CoverImage = "Assets/6.png" });
            books.Add(new Book { BookId = 8, Title = "Elip", Author = "Tempor", CoverImage = "Assets/7.png" });
            books.Add(new Book { BookId = 9, Title = "Elip", Author = "Tempor", CoverImage = "Assets/8.png" });
            books.Add(new Book { BookId = 10, Title = "Elip", Author = "Tempor", CoverImage = "Assets/9.png" });
            books.Add(new Book { BookId = 11, Title = "Elip", Author = "Tempor", CoverImage = "Assets/10.png" });
            books.Add(new Book { BookId = 12, Title = "Elip", Author = "Tempor", CoverImage = "Assets/11.png" });
            books.Add(new Book { BookId = 13, Title = "Elip", Author = "Tempor", CoverImage = "Assets/12.png" });
            books.Add(new Book { BookId = 14, Title = "Elip", Author = "Tempor", CoverImage = "Assets/13.png" });
            return books;


        }
    }
}
