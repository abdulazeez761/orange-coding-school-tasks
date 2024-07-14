using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvc_first_task.Context;
using mvc_first_task.Models;

namespace mvc_first_task.Controllers
{
    public class FeadbacksController : Controller
    {
        private readonly SystaemContext _context;

        public FeadbacksController(SystaemContext context)
        {
            _context = context;
        }

        // GET: Feadbacks
        public async Task<IActionResult> Index()
        {
            var systaemContext = _context.Feadbacks.Include(f => f.SentTo);
            return View(await systaemContext.ToListAsync());
        }

        // GET: Feadbacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feadbacks = await _context.Feadbacks
                .Include(f => f.SentTo)
                .FirstOrDefaultAsync(m => m.FeedbackID == id);
            if (feadbacks == null)
            {
                return NotFound();
            }

            return View(feadbacks);
        }

        // GET: Feadbacks/Create
        public IActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(_context.Employees, "EmployeeId", "FirstName");
            return View();
        }

        // POST: Feadbacks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FeedbackID,Title,SentToID,Viewed,Message,Date")] Feadbacks feadbacks)
        {


            try
            {
                _context.Add(feadbacks);
                await _context.SaveChangesAsync();
                ViewBag.EmployeeId = new SelectList(_context.Employees, "EmployeeId", "FirstName", feadbacks.SentToID);
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }

            ViewBag.EmployeeId = new SelectList(_context.Employees, "EmployeeId", "FirstName", feadbacks.SentToID);
            return View(feadbacks);

        }


        // GET: Feadbacks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feadbacks = await _context.Feadbacks.FindAsync(id);
            if (feadbacks == null)
            {
                return NotFound();
            }
            ViewData["ManagerID"] = new SelectList(_context.Managers, "EmployeeId");
            return View(feadbacks);
        }

        // POST: Feadbacks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FeedbackID,Title,ManagerID,Viewed,Message,Date")] Feadbacks feadbacks)
        {
            if (id != feadbacks.FeedbackID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feadbacks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeadbacksExists(feadbacks.FeedbackID))
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
            ViewData["ManagerID"] = new SelectList(_context.Managers, "EmployeeId");
            return View(feadbacks);
        }

        // GET: Feadbacks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feadbacks = await _context.Feadbacks
                .Include(f => f.SentTo)
                .FirstOrDefaultAsync(m => m.FeedbackID == id);
            if (feadbacks == null)
            {
                return NotFound();
            }

            return View(feadbacks);
        }

        // POST: Feadbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var feadbacks = await _context.Feadbacks.FindAsync(id);
            if (feadbacks != null)
            {
                _context.Feadbacks.Remove(feadbacks);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeadbacksExists(int id)
        {
            return _context.Feadbacks.Any(e => e.FeedbackID == id);
        }
    }
}
