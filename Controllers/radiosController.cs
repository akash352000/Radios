using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcRadios.Models;
using Radios.Data;

namespace Radios.Controllers
{
    public class radiosController : Controller
    {
        private readonly RadiosContext _context;

        public radiosController(RadiosContext context)
        {
            _context = context;
        }

        // GET: radios
        public async Task<IActionResult> Index()
        {
            return View(await _context.radios.ToListAsync());
        }

        // GET: radios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radios = await _context.radios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radios == null)
            {
                return NotFound();
            }

            return View(radios);
        }

        // GET: radios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: radios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LaunchDate,company,Price,type,Generation")] radios radios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radios);
        }

        // GET: radios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radios = await _context.radios.FindAsync(id);
            if (radios == null)
            {
                return NotFound();
            }
            return View(radios);
        }

        // POST: radios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,LaunchDate,company,Price,type,Generation")] radios radios)
        {
            if (id != radios.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!radiosExists(radios.Id))
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
            return View(radios);
        }

        // GET: radios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radios = await _context.radios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radios == null)
            {
                return NotFound();
            }

            return View(radios);
        }

        // POST: radios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var radios = await _context.radios.FindAsync(id);
            _context.radios.Remove(radios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool radiosExists(int id)
        {
            return _context.radios.Any(e => e.Id == id);
        }
    }
}
