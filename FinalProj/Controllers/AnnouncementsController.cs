using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProj.Data;
using FinalProj.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace FinalProj.Controllers
{
    [Authorize]
    public class AnnouncementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnnouncementsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Announcements
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Announcement.Include(a => a.Owner);
            return View(await applicationDbContext.ToListAsync());
            //string idLoggedUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var applicationDbContext = _context.Announcement.Include(n => n.Owner)
            //        .Where(n => n.OwnerID.Equals(idLoggedUser));
            //return View(await applicationDbContext.ToListAsync());

        }

        [Authorize(Roles = "Admin")]
        // GET: Announcements/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var announcement = await _context.Announcement
                .Include(a => a.Owner)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (announcement == null)
            {
                return NotFound();
            }

            return View(announcement);
        }

        [Authorize(Roles = "Admin")]
        // GET: Announcements/Create
        public IActionResult Create()
        {
            //ViewData["OwnerID"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            //return View();
            ViewData["OwnerID"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return PartialView();
        }

        // POST: Announcements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Body,Date,OwnerID")] Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(announcement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", announcement.OwnerID);
            return View(announcement);
        }

        [Authorize(Roles = "Admin")]
        // GET: Announcements/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var announcement = await _context.Announcement.FindAsync(id);
            if (announcement == null)
            {
                return NotFound();
            }
            ViewData["OwnerID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", announcement.OwnerID);
            return View(announcement);
        }

        // POST: Announcements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,Title,Body,Date,OwnerID")] Announcement announcement)
        {
            if (id != announcement.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(announcement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnnouncementExists(announcement.ID))
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
            ViewData["OwnerID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", announcement.OwnerID);
            return View(announcement);
        }

        [Authorize(Roles = "Admin")]
        // GET: Announcements/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var announcement = await _context.Announcement
                .Include(a => a.Owner)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (announcement == null)
            {
                return NotFound();
            }

            return View(announcement);
        }

        [Authorize(Roles = "Admin")]
        // POST: Announcements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var announcement = await _context.Announcement.FindAsync(id);
            _context.Announcement.Remove(announcement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnnouncementExists(long id)
        {
            return _context.Announcement.Any(e => e.ID == id);
        }
    }
}
