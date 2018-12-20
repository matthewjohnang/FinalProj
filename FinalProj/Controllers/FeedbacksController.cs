using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProj.Data;
using FinalProj.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace FinalProj.Controllers
{
    public class FeedbacksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FeedbacksController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        // GET: Feedbacks 
        public async Task<IActionResult> Index()
        {

            //var applicationDbContext = _context.Feedbacks.Include(f => f.Owner);
            //return View(await applicationDbContext.ToListAsync());

            string idLoggedUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var applicationDbContext = _context.Feedbacks.Include(n => n.Owner)
                    .Where(n => n.OwnerID.Equals(idLoggedUser));
            return View(await applicationDbContext.ToListAsync());

        }

        [Authorize(Roles = "Admin")]

        // GET: Feedback List
        public async Task<IActionResult> List()
        {
            //var applicationDbContext = _context.Feedbacks.FromSql("SELECT * FROM dbo.Feedbacks f join dbo.AspNetUsers au on au.Id = f.OwnerID");
            //return View(await applicationDbContext.ToListAsync());
            var applicationDbContext = _context.Feedbacks.Include(f => f.Owner);
            return View(await applicationDbContext.ToListAsync());
        }
        [Authorize]
        // GET: User List
        public IActionResult Userlist()
        {
            var Userlist = _context.Users.ToList();
            return View(Userlist);
        }
        [Authorize]
        // GET: Feedbacks/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedbacks
                .Include(f => f.Owner)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }
        [Authorize]
        // GET: Feedbacks/Create
        public IActionResult Create()
        {
            //ViewData["OwnerID"] = new SelectList(_context.Users, "Id", "Id");
            //return View();
            ViewData["OwnerID"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return PartialView();

        }

        // POST: Feedbacks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Body,OwnerID")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedback);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerID"] = new SelectList(_context.Users, "Id", "Id", feedback.OwnerID);
            return View(feedback);
        }
        [Authorize]
        // GET: Feedbacks/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedbacks.FindAsync(id);
            if (feedback == null)
            {
                return NotFound();
            }
            ViewData["OwnerID"] = new SelectList(_context.Users, "Id", "Id", feedback.OwnerID);
            return View(feedback);
        }

        // POST: Feedbacks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,Title,Body,OwnerID")] Feedback feedback)
        {
            if (id != feedback.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feedback);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackExists(feedback.ID))
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
            ViewData["OwnerID"] = new SelectList(_context.Users, "Id", "Id", feedback.OwnerID);
            return View(feedback);
        }
        [Authorize]
        // GET: Feedbacks/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedbacks
                .Include(f => f.Owner)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        // POST: Feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var feedback = await _context.Feedbacks.FindAsync(id);
            _context.Feedbacks.Remove(feedback);
            await _context.SaveChangesAsync();
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction(nameof(List));
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        private bool FeedbackExists(long id)
        {
            return _context.Feedbacks.Any(e => e.ID == id);
        }
    }
}
