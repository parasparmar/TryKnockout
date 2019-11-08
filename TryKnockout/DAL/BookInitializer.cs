using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TryKnockout.Models;

namespace TryKnockout.DAL
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var author = new Author
            {
                FirstName = "Paras",
                LastName = "Parmar",
                Biography = "The History of Rome"
            };

            var books = new List<Book>
            {
                new Book
                {
                    Author = author,
                    Description = "Lorem Ipsum",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "1491914319",
                    Synopsis = "...",
                    Title = "Build your own Roman Empire"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51AkFkNeUxL._AA160_.jpg",
                    Isbn = "1449319548",
                    Synopsis = "...",
                    Title = "Fighting Techniques of the Greeks"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51LpqnDq8-L._AA160_.jpg",
                    Isbn = "1449309860",
                    Synopsis = "...",
                    Title = "The Rise of the Babylonian Empire"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/41JC54HEroL._AA160_.jpg",
                    Isbn = "1460954394",
                    Synopsis = "...",
                    Title = "The Art of Fighting without Fighting"
                }
            };
            books.ForEach(b => context.Books.Add(b));


            author = new Author
            {
                FirstName = "Pratik",
                LastName = "Parmar",
                Biography = "Celebrated author of The Juggernaut of Nazi Germany"
            };

            books = new List<Book>
            {
                new Book
                {
                    Author = author,
                    Description = "Lorem Ipsum",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "14915674319",
                    Synopsis = "...",
                    Title = "The Juggernaut of Nazi Germany"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51AkFkNeUxL._AA160_.jpg",
                    Isbn = "14498910548",
                    Synopsis = "...",
                    Title = "Techniques of Warfare : 18th Century"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51LpqnDq8-L._AA160_.jpg",
                    Isbn = "141112139860",
                    Synopsis = "...",
                    Title = "A Concise Study of the Men and Women of the Second World War"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/41JC54HEroL._AA160_.jpg",
                    Isbn = "14608957894",
                    Synopsis = "...",
                    Title = "Combat Techniques of Nazi Germany"
                }
            };
            books.ForEach(b => context.Books.Add(b));

            context.SaveChanges();
        }
    }
}