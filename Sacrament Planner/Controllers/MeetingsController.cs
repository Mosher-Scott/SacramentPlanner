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
    public class MeetingsController : Controller
    {
        private readonly MeetingContext _context;

        public MeetingsController(MeetingContext context)
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
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meetings == null)
            {
                return NotFound();
            }

            return View(meetings);
        }

        // GET: Meetings/Create ORIGINAL
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // GET: Meetings/Create
        public IActionResult Create()
        {
            PopulateMembersDropDownList();
            return View();
        }

        // POST: Meetings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,Presiding,Conducting,IntermediateSong,IntermediateMusicalNumber,Speaker1,Speaker1Topic,Speaker2,Speaker2Topic,Speaker3,Speaker3Topic,Speaker4,Speaker4Topic,Speaker5,Speaker5Topic,Speaker6,Speaker6Topic,Speaker7,Speaker7Topic,OpeningHymn,SacramentHymn,ClosingHymn,OpeningPrayer,ClosingPrayer")] Meetings meetings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meetings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateMembersDropDownList(meetings.ID);
            return View(meetings);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetings = await _context.Meetings
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meetings == null)
            {
                return NotFound();
            }
            PopulateMembersDropDownList(meetings.ID);
            return View(meetings);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetingToUpdate = await _context.Meetings
                .FirstOrDefaultAsync(c => c.ID == id);

            if (await TryUpdateModelAsync<Meetings>(meetingToUpdate,
                "",
                c => c.Presiding, c=> c.SacramentHymn))
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
                return RedirectToAction(nameof(Index));
            }
            PopulateMembersDropDownList(meetingToUpdate.ID);
            return View(meetingToUpdate);
        }

        private void PopulateMembersDropDownList(object selectedMeeting= null)
        {
            var MembersQuery = from d in _context.Members
                                   orderby d.LastName
                                   select d;
            ViewBag.DepartmentID = new SelectList(MembersQuery.AsNoTracking(), "Members", "Name", selectedMeeting);
        }

        #region Original Create/Edit Methods
        // POST: Meetings/Create ORIGINAL
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ID,MeetingDate,Presiding,Conducting,IntermediateSong,IntermediateMusicalNumber,Speaker1,Speaker1Topic,Speaker2,Speaker2Topic,Speaker3,Speaker3Topic,Speaker4,Speaker4Topic,Speaker5,Speaker5Topic,Speaker6,Speaker6Topic,Speaker7,Speaker7Topic,OpeningHymn,SacramentHymn,ClosingHymn,OpeningPrayer,ClosingPrayer")] Meetings meetings)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(meetings);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(meetings);
        //}

        // GET: Meetings/Edit/5 ORIGINAL
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var meetings = await _context.Meetings.FindAsync(id);
        //    if (meetings == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(meetings);
        //}

        // POST: Meetings/Edit/5 ORIGINAL
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingDate,Presiding,Conducting,IntermediateSong,IntermediateMusicalNumber,Speaker1,Speaker1Topic,Speaker2,Speaker2Topic,Speaker3,Speaker3Topic,Speaker4,Speaker4Topic,Speaker5,Speaker5Topic,Speaker6,Speaker6Topic,Speaker7,Speaker7Topic,OpeningHymn,SacramentHymn,ClosingHymn,OpeningPrayer,ClosingPrayer")] Meetings meetings)
        //{
        //    if (id != meetings.ID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(meetings);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!MeetingsExists(meetings.ID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(meetings);
        //}
        #endregion

        // GET: Meetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetings = await _context.Meetings
                .AsNoTracking()
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
