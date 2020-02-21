using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarketSENA.Data;
using MarketSENA.Models;

namespace MarketSENA.Controllers
{
    public class GaleriasController : Controller
    {
        private readonly MarketSENAContext _context;

        public GaleriasController(MarketSENAContext context)
        {
            _context = context;
        }

        // GET: Galerias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Galeria.ToListAsync());
        }

        // GET: Galerias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galeria
                .FirstOrDefaultAsync(m => m.GaleriaID == id);
            if (galeria == null)
            {
                return NotFound();
            }

            return View(galeria);
        }

        // GET: Galerias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Galerias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GaleriaID,UrlImg")] Galeria galeria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(galeria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(galeria);
        }

        // GET: Galerias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galeria.FindAsync(id);
            if (galeria == null)
            {
                return NotFound();
            }
            return View(galeria);
        }

        // POST: Galerias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GaleriaID,UrlImg")] Galeria galeria)
        {
            if (id != galeria.GaleriaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(galeria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GaleriaExists(galeria.GaleriaID))
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
            return View(galeria);
        }

        // GET: Galerias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galeria
                .FirstOrDefaultAsync(m => m.GaleriaID == id);
            if (galeria == null)
            {
                return NotFound();
            }

            return View(galeria);
        }

        // POST: Galerias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var galeria = await _context.Galeria.FindAsync(id);
            _context.Galeria.Remove(galeria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GaleriaExists(int id)
        {
            return _context.Galeria.Any(e => e.GaleriaID == id);
        }
    }
}
