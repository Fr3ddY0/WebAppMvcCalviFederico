using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppMvcCalviFederico.Data;
using WebAppMvcCalviFederico.Models;

namespace WebAppMvcCalviFederico.Controllers
{
    public class AnagraficaCalviFedericoController : Controller
    {
        private readonly WebAppMvcCalviFedericoContext _context;

        public AnagraficaCalviFedericoController(WebAppMvcCalviFedericoContext context)
        {
            _context = context;
        }

        // GET: AnagraficaCalviFederico
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Anagrafica == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var ricerc = from m in _context.Anagrafica
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                ricerc = ricerc.Where(s => s.CodFiscale!.Contains(searchString));
            }

            return View(await ricerc.ToListAsync());
        }

        // GET: AnagraficaCalviFederico/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anagrafica = await _context.Anagrafica
                .FirstOrDefaultAsync(m => m.CodFiscale == id);
            if (anagrafica == null)
            {
                return NotFound();
            }

            return View(anagrafica);
        }

        // GET: AnagraficaCalviFederico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnagraficaCalviFederico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Cognome,DataNascita,Via,NumCivico,Citta,Cap,Provincia,Telefono,Email,Social,CodFiscale")] Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(anagrafica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(anagrafica);
        }

        // GET: AnagraficaCalviFederico/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anagrafica = await _context.Anagrafica.FindAsync(id);
            if (anagrafica == null)
            {
                return NotFound();
            }
            return View(anagrafica);
        }

        // POST: AnagraficaCalviFederico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Nome,Cognome,DataNascita,Via,NumCivico,Citta,Cap,Provincia,Telefono,Email,Social,CodFiscale")] Anagrafica anagrafica)
        {
            if (id != anagrafica.CodFiscale)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(anagrafica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnagraficaExists(anagrafica.CodFiscale))
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
            return View(anagrafica);
        }

        // GET: AnagraficaCalviFederico/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anagrafica = await _context.Anagrafica
                .FirstOrDefaultAsync(m => m.CodFiscale == id);
            if (anagrafica == null)
            {
                return NotFound();
            }

            return View(anagrafica);
        }

        // POST: AnagraficaCalviFederico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var anagrafica = await _context.Anagrafica.FindAsync(id);
            if (anagrafica != null)
            {
                _context.Anagrafica.Remove(anagrafica);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnagraficaExists(string id)
        {
            return _context.Anagrafica.Any(e => e.CodFiscale == id);
        }
    }
}
