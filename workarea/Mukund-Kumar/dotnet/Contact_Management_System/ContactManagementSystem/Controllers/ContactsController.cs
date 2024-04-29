using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactManagementSystem.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using OfficeOpenXml;


namespace ContactManagementSystem.Controllers
{
    [Authorize]
    public class ContactsController : Controller
    {
        private readonly ContactContext _context;
       
        public ContactsController(ContactContext context)
        {
            _context = context;
        }

        // GET: Contacts
        // GET: Contacts
        public async Task<IActionResult> Index(int? categoryId)
        {
            var query = _context.Contacts.Include(c => c.Category).Include(c => c.User).Where(i => i.UserID == GetCurrentUserId());

            // Filter by category if categoryId is provided
            if (categoryId != null)
            {
                query = query.Where(c => c.CategoryID == categoryId);
            }

            ViewBag.Categories = await _context.Categories.ToListAsync(); // Populate ViewBag.Categories

            return View(await query.ToListAsync());
        }


        // GET: Contacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .Include(c => c.Category)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Contacts/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryName");
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contact contact)
        {
            var userid=GetCurrentUserId();
            contact.UserID=userid;
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryName", contact.CategoryID);
            ViewData["UserID"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(contact);
        }

        // GET: Contacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryName", contact.CategoryID);
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", contact.UserID);
            return View(contact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,Email,CategoryID,UserID")] Contact contact)
        {
            if (id != contact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.Id))
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
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryName", contact.CategoryID);
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", contact.UserID);
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .Include(c => c.Category)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }

        private string GetCurrentUserId()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return userid;
        }

         // search operation 
        public async Task<IActionResult> Search(string searchTerm)
        {
            var Query = _context.Contacts.AsQueryable();

            // Check if a search term is provided
            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Filter books by title, ISBN, and author name containing the search term
                Query = Query.Where(b =>
                    EF.Functions.Like(b.FirstName, $"%{searchTerm}%") ||
                    EF.Functions.Like(b.LastName, $"%{searchTerm}%") ||
                    EF.Functions.Like(b.PhoneNumber, $"%{searchTerm}%") ||
                    EF.Functions.Like(b.Email, $"%{searchTerm}")
                );
                Query = Query.Where(u => u.UserID == GetCurrentUserId());
            }

            var contacts = await Query.ToListAsync();

            return View(contacts);
        }

        public byte[] GenerateAsExcel(List<Contact> contacts)
        {
            using (var package=new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Contacts");
                var userid=GetCurrentUserId();
                var user=_context.Users.FirstOrDefault(i=>i.Id == userid);

                //Add headings
                worksheet.Cells[1,1].Value = "FirstName";
                worksheet.Cells[2, 1].Value = "LastName";
                worksheet.Cells[3, 1].Value = "PhoneNumber";
                worksheet.Cells[4, 1].Value = "Email";
                

                string fullName = user.FullName;
                string phoneNumber=user.PhoneNumber;
                string email = user.Email;
                
                

            }
        }



       
    }
}
