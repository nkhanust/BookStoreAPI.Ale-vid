using BookStore.Data.interfaces;
using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Repositries
{
    public List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "The new girl on a train", Author = "xmen", PublicationYear = 2000 },
            new Book { Id = 2, Title = "Death", Author = "unknown", PublicationYear = 1910 },
            new Book { Id = 3, Title = "Forrest", Author = "child", PublicationYear = 1956 }
        };


    public class BookRepository : IBookRepository
    {
        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
        
    }




}
