using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaWA.Data;
using CinemaWA.Models;

namespace CinemaWA.Controllers
{
    public class ReservasController : Controller
    {
        private readonly CinemaWAContext _context;

        public ReservasController(CinemaWAContext context)
        {
            _context = context;
        }

        // GET: Reservas
        public async Task<IActionResult> Index()
        {
            var cinemaWAContext = _context.Reserva.Include(r => r.Assento).Include(r => r.Cliente).Include(r => r.Sessao);
            return View(await cinemaWAContext.ToListAsync());
        }

        // GET: Reservas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva
                .Include(r => r.Assento)
                .Include(r => r.Cliente)
                .Include(r => r.Sessao)
                .FirstOrDefaultAsync(m => m.ReservaId == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // GET: Reservas/Create
        public IActionResult Create()
        {
            ViewData["AssentoId"] = new SelectList(_context.Assento, "AssentoId", "AssentoInfo");
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteNome");
            ViewData["SessaoId"] = new SelectList(_context.Sessao, "SessaoId", "Sessaoinfo");
            return View();
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservaId,ClienteId,SessaoId,AssentoId")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AssentoId"] = new SelectList(_context.Assento, "AssentoId", "AssentoId", reserva.AssentoId);
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", reserva.ClienteId);
            ViewData["SessaoId"] = new SelectList(_context.Sessao, "SessaoId", "SessaoId", reserva.SessaoId);
            return View(reserva);
        }

        // GET: Reservas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }
            ViewData["AssentoId"] = new SelectList(_context.Assento, "AssentoId", "AssentoId", reserva.AssentoId);
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", reserva.ClienteId);
            ViewData["SessaoId"] = new SelectList(_context.Sessao, "SessaoId", "SessaoId", reserva.SessaoId);
            return View(reserva);
        }

        // POST: Reservas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservaId,ClienteId,SessaoId,AssentoId")] Reserva reserva)
        {
            if (id != reserva.ReservaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservaExists(reserva.ReservaId))
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
            ViewData["AssentoId"] = new SelectList(_context.Assento, "AssentoId", "AssentoId", reserva.AssentoId);
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", reserva.ClienteId);
            ViewData["SessaoId"] = new SelectList(_context.Sessao, "SessaoId", "SessaoId", reserva.SessaoId);
            return View(reserva);
        }

        // GET: Reservas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva
                .Include(r => r.Assento)
                .Include(r => r.Cliente)
                .Include(r => r.Sessao)
                .FirstOrDefaultAsync(m => m.ReservaId == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserva = await _context.Reserva.FindAsync(id);
            _context.Reserva.Remove(reserva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservaExists(int id)
        {
            return _context.Reserva.Any(e => e.ReservaId == id);
        }
    }
}
