﻿using System;
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
    public class MeetingsControllerOLD : Controller
    {
        private readonly MeetingContext _context;

        public MeetingsControllerOLD(MeetingContext context)
        {
            _context = context;
        }

        // GET: Meetings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Meetings.ToListAsync());
        }

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetings = await _context.Meetings
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meetings == null)
            {
                return NotFound();
            }

            return View(meetings);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,Presiding,Conducting,IntermediateSong,IntermediateMusicalNumber,Speaker1,Speaker2,Speaker3,Speaker4,Speaker5,Speaker6,Speaker7,OpeningHymn,SacramentHymn,ClosingHymn,OpeningPrayer,ClosingPrayer")] Meetings meetings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meetings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meetings);
        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetings = await _context.Meetings.FindAsync(id);
            if (meetings == null)
            {
                return NotFound();
            }
            return View(meetings);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingDate,Presiding,Conducting,IntermediateSong,IntermediateMusicalNumber,Speaker1,Speaker2,Speaker3,Speaker4,Speaker5,Speaker6,Speaker7,OpeningHymn,SacramentHymn,ClosingHymn,OpeningPrayer,ClosingPrayer")] Meetings meetings)
        {
            if (id != meetings.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meetings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingsExists(meetings.ID))
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
            return View(meetings);
        }

        // GET: Meetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetings = await _context.Meetings
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meetings == null)
            {
                return NotFound();
            }

            return View(meetings);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meetings = await _context.Meetings.FindAsync(id);
            _context.Meetings.Remove(meetings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingsExists(int id)
        {
            return _context.Meetings.Any(e => e.ID == id);
        }
    }
}
