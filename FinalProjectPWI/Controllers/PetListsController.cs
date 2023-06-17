using FinalProjectPWI.Data;
using FinalProjectPWI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectPWI.Controllers
{
    public class PetListsController : Controller
    {
        private readonly PetListDbContext _context;

        public PetListsController(PetListDbContext context)
        {
            _context = context;
        }

        // GET: PetLists
        public async Task<IActionResult> Index()
        {
            return _context.PetList != null ?
                        View(await _context.PetList.ToListAsync()) :
                        Problem("Entity set 'PetListDbContext.PetList'  is null.");
        }

        // GET: PetLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PetList == null)
            {
                return NotFound();
            }

            var petList = await _context.PetList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (petList == null)
            {
                return NotFound();
            }

            return View(petList);
        }

        // GET: PetLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PetLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OwnerName,PetName,PetType,PetBreed")] PetList petList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(petList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(petList);
        }

        // GET: PetLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PetList == null)
            {
                return NotFound();
            }

            var petList = await _context.PetList.FindAsync(id);
            if (petList == null)
            {
                return NotFound();
            }
            return View(petList);
        }

        // POST: PetLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OwnerName,PetName,PetType,PetBreed")] PetList petList)
        {
            if (id != petList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(petList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetListExists(petList.Id))
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
            return View(petList);
        }

        // GET: PetLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PetList == null)
            {
                return NotFound();
            }

            var petList = await _context.PetList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (petList == null)
            {
                return NotFound();
            }

            return View(petList);
        }

        // POST: PetLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PetList == null)
            {
                return Problem("Entity set 'PetListDbContext.PetList'  is null.");
            }
            var petList = await _context.PetList.FindAsync(id);
            if (petList != null)
            {
                _context.PetList.Remove(petList);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetListExists(int id)
        {
            return (_context.PetList?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
