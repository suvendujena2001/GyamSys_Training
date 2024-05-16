using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookAPI.Models;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksDbContext _context;

        public BooksController(BooksDbContext context)
        {
            _context = context;
        }

        // GET: api/Books


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _context.Books
                .Select(b => new Book
                {
                    ISBN = b.ISBN,
                    BookTitle = b.BookTitle,
                    BookAuthor = b.BookAuthor,
                    YearOfPublication = b.YearOfPublication,
                    Publisher = b.Publisher,
                    ImageUrl_S = b.ImageUrl_S,
                    ImageUrl_M = b.ImageUrl_M,
                    ImageUrl_L = b.ImageUrl_L,
                    TotalLikes = _context.Stats.Where(s => s.ISBN == b.ISBN).Sum((Stat s) => s.Likes),
                    AverageRating = _context.Stats.Where(s => s.ISBN == b.ISBN).Any() ?
                    _context.Stats.Where(s => s.ISBN == b.ISBN).Average(s => s.Rating) :
                    0
        })
                .ToListAsync();

            return Ok(books);
        }


        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(string id)
        {
            var book = await _context.Books
                .FirstOrDefaultAsync(b => b.ISBN == id);

            if (book == null)
            {
                return NotFound();
            }
            // Calculate totalLikes and averageRating
            var totalLikes = _context.Stats.Where(s => s.ISBN == id).Sum((Stat s) => s.Likes);
            var averageRating = _context.Stats.Where(s => s.ISBN == id).Any() ?
                    _context.Stats.Where(s => s.ISBN == id).Average(s => s.Rating) :
                    0;


            // Create a new Book object with calculated fields
            var bookDto = new Book
            {
                ISBN = book.ISBN,
                BookTitle = book.BookTitle,
                BookAuthor = book.BookAuthor,
                YearOfPublication = book.YearOfPublication,
                Publisher = book.Publisher,
                ImageUrl_S = book.ImageUrl_S,
                ImageUrl_M = book.ImageUrl_M,
                ImageUrl_L = book.ImageUrl_L,
                TotalLikes = totalLikes,
                AverageRating = averageRating
            };
            book.TotalLikes = totalLikes;
            book.AverageRating = averageRating; 
         
            _context.SaveChanges();
            return Ok(bookDto);
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(string id, Book book)
        {
            if (id != book.ISBN)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            _context.Books.Add(book);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BookExists(book.ISBN))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBook", new { id = book.ISBN }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(string id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookExists(string id)
        {
            return _context.Books.Any(e => e.ISBN == id);
        }
    }
}
