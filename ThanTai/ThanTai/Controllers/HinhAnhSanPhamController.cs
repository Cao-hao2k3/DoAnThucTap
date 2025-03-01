using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThanTai.Models;

namespace ThanTai.Controllers
{
    public class HinhAnhSanPhamController : Controller
    {
        private readonly ThanTaiShopDbContext _context;

        public HinhAnhSanPhamController(ThanTaiShopDbContext context)
        {
            _context = context;
        }

        // GET: HinhAnhSanPham
        public async Task<IActionResult> Index()
        {
            var thanTaiShopDbContext = _context.HinhAnhSanPham.Include(h => h.SanPham);
            return View(await thanTaiShopDbContext.ToListAsync());
        }

        // GET: HinhAnhSanPham/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hinhAnhSanPham = await _context.HinhAnhSanPham
                .Include(h => h.SanPham)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hinhAnhSanPham == null)
            {
                return NotFound();
            }

            return View(hinhAnhSanPham);
        }

        // GET: HinhAnhSanPham/Create
        public IActionResult Create()
        {
            ViewData["SanPhamID"] = new SelectList(_context.SanPham, "ID", "TenSanPham");
            return View();
        }

        // POST: HinhAnhSanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,SanPhamID,AnhSanPham,AnhThongSo")] HinhAnhSanPham hinhAnhSanPham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hinhAnhSanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SanPhamID"] = new SelectList(_context.SanPham, "ID", "TenSanPham", hinhAnhSanPham.SanPhamID);
            return View(hinhAnhSanPham);
        }

        // GET: HinhAnhSanPham/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hinhAnhSanPham = await _context.HinhAnhSanPham.FindAsync(id);
            if (hinhAnhSanPham == null)
            {
                return NotFound();
            }
            ViewData["SanPhamID"] = new SelectList(_context.SanPham, "ID", "TenSanPham", hinhAnhSanPham.SanPhamID);
            return View(hinhAnhSanPham);
        }

        // POST: HinhAnhSanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,SanPhamID,AnhSanPham,AnhThongSo")] HinhAnhSanPham hinhAnhSanPham)
        {
            if (id != hinhAnhSanPham.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hinhAnhSanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HinhAnhSanPhamExists(hinhAnhSanPham.ID))
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
            ViewData["SanPhamID"] = new SelectList(_context.SanPham, "ID", "TenSanPham", hinhAnhSanPham.SanPhamID);
            return View(hinhAnhSanPham);
        }

        // GET: HinhAnhSanPham/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hinhAnhSanPham = await _context.HinhAnhSanPham
                .Include(h => h.SanPham)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hinhAnhSanPham == null)
            {
                return NotFound();
            }

            return View(hinhAnhSanPham);
        }

        // POST: HinhAnhSanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hinhAnhSanPham = await _context.HinhAnhSanPham.FindAsync(id);
            if (hinhAnhSanPham != null)
            {
                _context.HinhAnhSanPham.Remove(hinhAnhSanPham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HinhAnhSanPhamExists(int id)
        {
            return _context.HinhAnhSanPham.Any(e => e.ID == id);
        }
    }
}
