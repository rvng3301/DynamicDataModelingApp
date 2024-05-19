using System;
using System.Linq;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            // Look for any books.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            var authors = new Author[]
            {
                new Author{Name="J.K. Rowling", BirthDate=DateTime.Parse("1965-07-31")},
                new Author{Name="George R.R. Martin", BirthDate=DateTime.Parse("1948-09-20")}
            };

            foreach (var a in authors)
            {
                context.Authors.Add(a);
            }
            context.SaveChanges();

            var books = new Book[]
            {
                new Book{Title="Harry Potter and the Philosopher's Stone", Genre="Fantasy", AuthorId=authors[0].AuthorId, PublicationYear=1997, Summary="The first book in the Harry Potter series."},
                new Book{Title="A Game of Thrones", Genre="Fantasy", AuthorId=authors[1].AuthorId, PublicationYear=1996, Summary="The first book in A Song of Ice and Fire series."}
            };

            foreach (var b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();
        }
    }
}