using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;
using WebApplication2.Services.Communications;
using WebApplication2.Services.Interfaces;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetAllAsync()
        {

            var books = await _bookService.ListAsync();
            return books;
        }

        [HttpPost]
        public async Task<BookResponse> AddBookAsync(Book book)
        {
            await _bookService.AddAsync(book);

            return new BookResponse(book);
        }
    }
}
