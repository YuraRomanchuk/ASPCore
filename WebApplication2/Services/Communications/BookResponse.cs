using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.Communications
{
    public class BookResponse : BaseResponse
    {
    public Book Book { get; private set; }

    private BookResponse(bool success, string message, Book Book) : base(success, message)
    {
        Book = Book;
    }

    /// <summary>
    /// Creates a success response.
    /// </summary>
    /// <param name="Book">Saved Book.</param>
    /// <returns>Response.</returns>
    public BookResponse(Book Book) : this(true, string.Empty, Book)
    { }

    /// <summary>
    /// Creates am error response.
    /// </summary>
    /// <param name="message">Error message.</param>
    /// <returns>Response.</returns>
    public BookResponse(string message) : this(false, message, null)
    { }
}
}
