using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodTrackerApp.Data;
using MoodTrackerApp.Models;

namespace MoodTrackerApp.Controllers
{
    public class MoodEntriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoodEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MoodEntries
        public async Task<IActionResult> Index()
        {
            return View(await _context.MoodEntries.ToListAsync());
        }

        // GET: MoodEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var moodEntry = await _context.MoodEntries.FirstOrDefaultAsync(m => m.Id == id);
            if (moodEntry == null) return NotFound();

            return View(moodEntry);
        }

        // GET: MoodEntries/Create
        public IActionResult Create() => View();

        // POST: MoodEntries/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Mood,Note")] MoodEntry moodEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moodEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moodEntry);
        }

        // GET: MoodEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var moodEntry = await _context.MoodEntries.FindAsync(id);
            if (moodEntry == null) return NotFound();

            return View(moodEntry);
        }

        // POST: MoodEntries/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Mood,Note")] MoodEntry moodEntry)
        {
            if (id != moodEntry.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moodEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoodEntryExists(moodEntry.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(moodEntry);
        }

        // GET: MoodEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var moodEntry = await _context.MoodEntries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moodEntry == null) return NotFound();

            return View(moodEntry);
        }

        // POST: MoodEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moodEntry = await _context.MoodEntries.FindAsync(id);
            if (moodEntry != null)
            {
                _context.MoodEntries.Remove(moodEntry);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool MoodEntryExists(int id)
        {
            return _context.MoodEntries.Any(e => e.Id == id);
        }
    }
}
