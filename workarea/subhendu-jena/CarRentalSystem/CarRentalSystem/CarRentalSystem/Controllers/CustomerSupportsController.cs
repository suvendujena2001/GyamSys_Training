using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRentalSystem.Models;

namespace CarRentalSystem.Controllers
{
    public class CustomerSupportsController : Controller
    {
        private readonly CarRentalContext _context;

        public CustomerSupportsController(CarRentalContext context)
        {
            _context = context;
        }

        // GET: CustomerSupports
        public async Task<IActionResult> Index()
        {
            var carRentalContext = _context.CustomerSupports.Include(c => c.User);
            return View(await carRentalContext.ToListAsync());
        }

        // GET: CustomerSupports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerSupport = await _context.CustomerSupports
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.SupportId == id);
            if (customerSupport == null)
            {
                return NotFound();
            }

            return View(customerSupport);
        }

        // GET: CustomerSupports/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }

        // POST: CustomerSupports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupportId,UserId,Timestamp,Channel,Message,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] CustomerSupport customerSupport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerSupport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", customerSupport.UserId);
            return View(customerSupport);
        }

        // GET: CustomerSupports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerSupport = await _context.CustomerSupports.FindAsync(id);
            if (customerSupport == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", customerSupport.UserId);
            return View(customerSupport);
        }

        // POST: CustomerSupports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupportId,UserId,Timestamp,Channel,Message,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] CustomerSupport customerSupport)
        {
            if (id != customerSupport.SupportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerSupport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerSupportExists(customerSupport.SupportId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", customerSupport.UserId);
            return View(customerSupport);
        }

        // GET: CustomerSupports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerSupport = await _context.CustomerSupports
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.SupportId == id);
            if (customerSupport == null)
            {
                return NotFound();
            }

            return View(customerSupport);
        }

        // POST: CustomerSupports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerSupport = await _context.CustomerSupports.FindAsync(id);
            if (customerSupport != null)
            {
                _context.CustomerSupports.Remove(customerSupport);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerSupportExists(int id)
        {
            return _context.CustomerSupports.Any(e => e.SupportId == id);
        }
    }
}
