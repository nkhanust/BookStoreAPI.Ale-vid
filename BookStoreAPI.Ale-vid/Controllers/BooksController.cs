using BookStore.Data.interfaces;
using BookStore.Data.Models;
using BookStore.Data.Repositries;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;


namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BooksController : ControllerBase
    {
        //public List<Book> books = new List<Book>()
        //{
        //    new Book { Id = 1, Title = "The new girl on a train", Author = "xmen", PublicationYear = 2000 },
        //    new Book { Id = 2, Title = "Death", Author = "unknown", PublicationYear = 1910 },
        //    new Book { Id = 3, Title = "Forrest", Author = "child", PublicationYear = 1956 }
        //};

        private BookRepository books = new BookRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }
         
        [HttpGet("{id}")]

        public ActionResult<Book> GetBook(int id)
        {
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}