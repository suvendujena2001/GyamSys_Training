using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStoreApp.Data;
using BookStoreApp.Models;

namespace BookStoreApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookStoreAppContext _context;

        public BooksController(BookStoreAppContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var bookStoreAppContext = _context.Books.Include(b => b.Author).Include(b => b.Genre).Include(b => b.User);
            return View(await bookStoreAppContext.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewData["AuthorID"] = new SelectList(_context.Authors, "AuthorID", "AuthorID");
            ViewData["GenreID"] = new SelectList(_context.Genres, "GenreID", "GenreID");
            ViewData["UserId"] = new SelectList(_context.Users, "UserID", "UserID");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                // Check if the author name already exists in the database
                var existingAuthor = await _context.Authors.FirstOrDefaultAsync(a => a.AuthorName == book.AuthorName);
                var existingGenre = await _context.Genres.FirstOrDefaultAsync(a => a.GenreName == book.GenreName);
                // If author name doesn't exist, create a new author
                if (existingAuthor == null)
                {
                    var newAuthor = new Author { AuthorName = book.AuthorName };
                    _context.Authors.Add(newAuthor);
                    await _context.SaveChangesAsync(); // Save changes to generate author ID
                    book.AuthorID = newAuthor.AuthorID; // Assign the generated author ID to the book
                }
                else
                {
                    book.AuthorID = existingAuthor.AuthorID; // Use existing author ID
                }

                if (existingGenre == null)
                {
                    var newGenre = new Genre { GenreName = book.GenreName };
                    _context.Genres.Add(newGenre);
                    await _context.SaveChangesAsync(); // Save changes to generate author ID
                    book.GenreID = newGenre.GenreID; // Assign the generated author ID to the book
                }
                else
                {
                    book.GenreID = existingGenre.GenreID; // Use existing author ID
                }

                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("BookID,ISBN,Title,AuthorID,AuthorName,GenreID,GenreName,CoverImage,Price,Page,Description,PublicationDate,Popularity,Availability,UserId,CreatedDate,UpdatedDate")] Book book)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(book);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AuthorID"] = new SelectList(_context.Authors, "AuthorID", "AuthorID", book.AuthorID);
        //    ViewData["GenreID"] = new SelectList(_context.Genres, "GenreID", "GenreID", book.GenreID);
        //    ViewData["UserId"] = new SelectList(_context.Users, "UserID", "UserID", book.UserId);
        //    return View(book);
        //}



        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["AuthorID"] = new SelectList(_context.Authors, "AuthorID", "AuthorID", book.AuthorID);
            ViewData["GenreID"] = new SelectList(_context.Genres, "GenreID", "GenreID", book.GenreID);
            ViewData["UserId"] = new SelectList(_context.Users, "UserID", "UserID", book.UserId);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookID,ISBN,Title,AuthorID,AuthorName,GenreID,GenreName,CoverImage,Price,Page,Description,PublicationDate,Popularity,Availability,UserId,CreatedDate,UpdatedDate")] Book book)
        {
            if (id != book.BookID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingAuthor = await _context.Authors.FirstOrDefaultAsync(a => a.AuthorName == book.AuthorName);
                    var existingGenre = await _context.Genres.FirstOrDefaultAsync(a => a.GenreName == book.GenreName);
                    // If author name doesn't exist, create a new author
                    if (existingAuthor == null)
                    {
                        var newAuthor = new Author { AuthorName = book.AuthorName };
                        _context.Authors.Add(newAuthor);
                        await _context.SaveChangesAsync(); // Save changes to generate author ID
                        book.AuthorID = newAuthor.AuthorID; // Assign the generated author ID to the book
                    }
                    else
                    {
                        book.AuthorID = existingAuthor.AuthorID; // Use existing author ID
                    }

                    if (existingGenre == null)
                    {
                        var newGenre = new Genre { GenreName = book.GenreName };
                        _context.Genres.Add(newGenre);
                        await _context.SaveChangesAsync(); // Save changes to generate author ID
                        book.GenreID = newGenre.GenreID; // Assign the generated author ID to the book
                    }
                    else
                    {
                        book.GenreID = existingGenre.GenreID; // Use existing author ID
                    }
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorID"] = new SelectList(_context.Authors, "AuthorID", "AuthorID", book.AuthorID);
            ViewData["GenreID"] = new SelectList(_context.Genres, "GenreID", "GenreID", book.GenreID);
            ViewData["UserId"] = new SelectList(_context.Users, "UserID", "UserID", book.UserId);
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.BookID == id);
        }

        public IActionResult GetGenreName(int genreId)
        {
            // Find the genre with the given ID in the database
            var genre = _context.Genres.Find(genreId);

            // Check if the genre exists
            if (genre != null)
            {
                // Return the genre name as JSON
                return Json(new { genreName = genre.GenreName });
            }
            else
            {
                // If genre is not found, return an empty response or appropriate error
                return NotFound();
            }
        }

        public IActionResult GetAuthorName(int authorId)
        {
            // Find the genre with the given ID in the database
            var author = _context.Authors.Find(authorId);

            // Check if the genre exists
            if (author != null)
            {
                // Return the genre name as JSON
                return Json(new { AuthorName = author.AuthorName });
            }
            else
            {
                // If genre is not found, return an empty response or appropriate error
                return NotFound();
            }
        }

    }
}
