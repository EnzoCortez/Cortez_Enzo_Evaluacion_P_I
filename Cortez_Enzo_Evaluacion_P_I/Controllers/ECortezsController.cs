using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cortez_Enzo_Evaluacion_P_I.Data;
using Cortez_Enzo_Evaluacion_P_I.Models;

namespace Cortez_Enzo_Evaluacion_P_I.Controllers
{
    public class ECortezsController : Controller
    {
        private readonly Cortez_Enzo_Evaluacion_P_IContext _context;

        public ECortezsController(Cortez_Enzo_Evaluacion_P_IContext context)
        {
            _context = context;
        }

        // GET: ECortezs
        public async Task<IActionResult> Index()
        {
            var cortez_Enzo_Evaluacion_P_IContext = _context.ECortez.Include(e => e.Celular);
            return View(await cortez_Enzo_Evaluacion_P_IContext.ToListAsync());
        }

        // GET: ECortezs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eCortez = await _context.ECortez
                .Include(e => e.Celular)
                .FirstOrDefaultAsync(m => m.Cedula == id);
            if (eCortez == null)
            {
                return NotFound();
            }

            return View(eCortez);
        }

        // GET: ECortezs/Create
        public IActionResult Create()
        {
            ViewData["CelularId"] = new SelectList(_context.Celular, "Id", "Id");
            return View();
        }

        // POST: ECortezs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cedula,Nombre,Mesada,Estudiante,Cummpleaños,CelularId")] ECortez eCortez)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eCortez);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CelularId"] = new SelectList(_context.Celular, "Id", "Id", eCortez.CelularId);
            return View(eCortez);
        }

        // GET: ECortezs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eCortez = await _context.ECortez.FindAsync(id);
            if (eCortez == null)
            {
                return NotFound();
            }
            ViewData["CelularId"] = new SelectList(_context.Celular, "Id", "Id", eCortez.CelularId);
            return View(eCortez);
        }

        // POST: ECortezs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cedula,Nombre,Mesada,Estudiante,Cummpleaños,CelularId")] ECortez eCortez)
        {
            if (id != eCortez.Cedula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eCortez);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ECortezExists(eCortez.Cedula))
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
            ViewData["CelularId"] = new SelectList(_context.Celular, "Id", "Id", eCortez.CelularId);
            return View(eCortez);
        }

        // GET: ECortezs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eCortez = await _context.ECortez
                .Include(e => e.Celular)
                .FirstOrDefaultAsync(m => m.Cedula == id);
            if (eCortez == null)
            {
                return NotFound();
            }

            return View(eCortez);
        }

        // POST: ECortezs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eCortez = await _context.ECortez.FindAsync(id);
            if (eCortez != null)
            {
                _context.ECortez.Remove(eCortez);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ECortezExists(int id)
        {
            return _context.ECortez.Any(e => e.Cedula == id);
        }
    }
}
