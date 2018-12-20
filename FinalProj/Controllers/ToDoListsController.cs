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
    public class ToDoListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ToDoListsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        // GET: ToDoLists
        public async Task<IActionResult> Index()
        {
            string idLoggedUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var applicationDbContext = _context.ToDoList.Include(n => n.Owner)
                    .Where(n => n.OwnerID.Equals(idLoggedUser));
            return View(await applicationDbContext.ToListAsync());

        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> List()
        {
            var applicationDbContext = _context.ToDoList.Include(t => t.Owner);
            return View(await applicationDbContext.ToListAsync());
        }
        [Authorize]
        // GET: ToDoLists/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toDoList = await _context.ToDoList
                .Include(t => t.Owner)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (toDoList == null)
            {
                return NotFound();
            }

            return View(toDoList);
        }
        [Authorize]
        // GET: ToDoLists/Create
        public IActionResult Create()
        {
            //ViewData["OwnerID"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            //return View();

            ViewData["OwnerID"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return PartialView();

        }

        // POST: ToDoLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Description,Priority,Status,OwnerID")] ToDoList toDoList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(toDoList);
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
            ViewData["OwnerID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", toDoList.OwnerID);

            return View(toDoList);
        }

        public IActionResult Create_Admin()
        {
            ViewData["OwnerID"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return PartialView();

        }

        // POST: ToDoLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create_Admin([Bind("ID,Title,Description,Priority,Status,OwnerID")] ToDoList toDoList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(toDoList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", toDoList.OwnerID);
            return View(toDoList);
        }

        [Authorize]
        // GET: ToDoLists/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toDoList = await _context.ToDoList.FindAsync(id);
            if (toDoList == null)
            {
                return NotFound();
            }
            ViewData["OwnerID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", toDoList.OwnerID);
            return View(toDoList);
        }

        // POST: ToDoLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,Title,Description,Priority,Status,OwnerID")] ToDoList toDoList)
        {
            if (id != toDoList.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(toDoList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToDoListExists(toDoList.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if(User.IsInRole("Admin"))
                {
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["OwnerID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", toDoList.OwnerID);
            return View(toDoList);
        }
        [Authorize]
        // GET: ToDoLists/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toDoList = await _context.ToDoList
                .Include(t => t.Owner)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (toDoList == null)
            {
                return NotFound();
            }

            return View(toDoList);
        }

        // POST: ToDoLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var toDoList = await _context.ToDoList.FindAsync(id);
            _context.ToDoList.Remove(toDoList);
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

        private bool ToDoListExists(long id)
        {
            return _context.ToDoList.Any(e => e.ID == id);
        }
    }
}
