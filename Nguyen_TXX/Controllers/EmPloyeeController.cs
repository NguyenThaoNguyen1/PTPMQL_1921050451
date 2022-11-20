using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nguyen_TXX.Models;

namespace Nguyen_TXX.Controllers
{
    public class EmPloyeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmPloyeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmPloyee
        public async Task<IActionResult> Index()
        {
              return _context.EmPloyee != null ? 
                          View(await _context.EmPloyee.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.EmPloyee'  is null.");
        }

        // GET: EmPloyee/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.EmPloyee == null)
            {
                return NotFound();
            }

            var emPloyee = await _context.EmPloyee
                .FirstOrDefaultAsync(m => m.EmPloyeeID == id);
            if (emPloyee == null)
            {
                return NotFound();
            }

            return View(emPloyee);
        }

        // GET: EmPloyee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmPloyee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmPloyeeID,EmPloyeeName,Address,sdt,GioiTinh,Ngaysinh")] EmPloyee emPloyee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emPloyee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emPloyee);
        }

        // GET: EmPloyee/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.EmPloyee == null)
            {
                return NotFound();
            }

            var emPloyee = await _context.EmPloyee.FindAsync(id);
            if (emPloyee == null)
            {
                return NotFound();
            }
            return View(emPloyee);
        }

        // POST: EmPloyee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("EmPloyeeID,EmPloyeeName,Address,sdt,GioiTinh,Ngaysinh")] EmPloyee emPloyee)
        {
            if (id != emPloyee.EmPloyeeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emPloyee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmPloyeeExists(emPloyee.EmPloyeeID))
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
            return View(emPloyee);
        }

        // GET: EmPloyee/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.EmPloyee == null)
            {
                return NotFound();
            }

            var emPloyee = await _context.EmPloyee
                .FirstOrDefaultAsync(m => m.EmPloyeeID == id);
            if (emPloyee == null)
            {
                return NotFound();
            }

            return View(emPloyee);
        }

        // POST: EmPloyee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.EmPloyee == null)
            {
                return Problem("Entity set 'ApplicationDbContext.EmPloyee'  is null.");
            }
            var emPloyee = await _context.EmPloyee.FindAsync(id);
            if (emPloyee != null)
            {
                _context.EmPloyee.Remove(emPloyee);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmPloyeeExists(string id)
        {
          return (_context.EmPloyee?.Any(e => e.EmPloyeeID == id)).GetValueOrDefault();
        }
    }
}
