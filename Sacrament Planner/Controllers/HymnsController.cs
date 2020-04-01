using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sacrament_Planner.Data;
using Sacrament_Planner.Models;

namespace Sacrament_Planner.Controllers
{
    public class HymnsController : Controller
    {
        private readonly MeetingContext _context;

        public HymnsController(MeetingContext context)
        {
            _context = context;
        }

        // GET: Hymns
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hymns.ToListAsync());
        }

        // GET: Hymns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hymns = await _context.Hymns
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hymns == null)
            {
                return NotFound();
            }

            return View(hymns);
        }

        // GET: Hymns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hymns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,HymnName,PageNumber")] Hymns hymns)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hymns);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hymns);
        }

        // GET: Hymns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hymns = await _context.Hymns.FindAsync(id);
            if (hymns == null)
            {
                return NotFound();
            }
            return View(hymns);
        }

        // POST: Hymns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,HymnName,PageNumber")] Hymns hymns)
        {
            if (id != hymns.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hymns);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HymnsExists(hymns.ID))
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
            return View(hymns);
        }

        // GET: Hymns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hymns = await _context.Hymns
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hymns == null)
            {
                return NotFound();
            }

            return View(hymns);
        }

        // POST: Hymns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hymns = await _context.Hymns.FindAsync(id);
            _context.Hymns.Remove(hymns);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HymnsExists(int id)
        {
            return _context.Hymns.Any(e => e.ID == id);
        }
    }
}
