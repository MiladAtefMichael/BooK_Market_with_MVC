using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BooK_Market.Models;
using BooK_Market.Models.Data;

namespace BooK_Market.Controllers
{
    public class PriceOffersController : Controller
    {
        private readonly DB _context;

        public PriceOffersController(DB context)
        {
            _context = context;
        }

        // GET: PriceOffers
        public async Task<IActionResult> Index()
        {
              return View(await _context.PriceOffers.ToListAsync());
        }

        // GET: PriceOffers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PriceOffers == null)
            {
                return NotFound();
            }

            var priceOffers = await _context.PriceOffers
                .FirstOrDefaultAsync(m => m.PriceOfersId == id);
            if (priceOffers == null)
            {
                return NotFound();
            }

            return View(priceOffers);
        }

        // GET: PriceOffers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PriceOffers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PriceOfersId,NewPrice,PromaotionText")] PriceOffers priceOffers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(priceOffers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(priceOffers);
        }

        // GET: PriceOffers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PriceOffers == null)
            {
                return NotFound();
            }

            var priceOffers = await _context.PriceOffers.FindAsync(id);
            if (priceOffers == null)
            {
                return NotFound();
            }
            return View(priceOffers);
        }

        // POST: PriceOffers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PriceOfersId,NewPrice,PromaotionText")] PriceOffers priceOffers)
        {
            if (id != priceOffers.PriceOfersId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(priceOffers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PriceOffersExists(priceOffers.PriceOfersId))
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
            return View(priceOffers);
        }

        // GET: PriceOffers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PriceOffers == null)
            {
                return NotFound();
            }

            var priceOffers = await _context.PriceOffers
                .FirstOrDefaultAsync(m => m.PriceOfersId == id);
            if (priceOffers == null)
            {
                return NotFound();
            }

            return View(priceOffers);
        }

        // POST: PriceOffers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PriceOffers == null)
            {
                return Problem("Entity set 'DB.PriceOffers'  is null.");
            }
            var priceOffers = await _context.PriceOffers.FindAsync(id);
            if (priceOffers != null)
            {
                _context.PriceOffers.Remove(priceOffers);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PriceOffersExists(int id)
        {
          return _context.PriceOffers.Any(e => e.PriceOfersId == id);
        }
    }
}
