using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopPhone.Models;

namespace ShopPhone.Controllers
{
    public class ChitietdonhangsController : Controller
    {
        private readonly QLDienThoaiContext _context;

        public ChitietdonhangsController(QLDienThoaiContext context)
        {
            _context = context;
        }

        // GET: Chitietdonhangs
        public async Task<IActionResult> Index()
        {
            var qLDienThoaiContext = _context.Chitietdonhangs.Include(c => c.MaDonNavigation).Include(c => c.MaSanPhamNavigation);
            return View(await qLDienThoaiContext.ToListAsync());
        }

        // GET: Chitietdonhangs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietdonhang = await _context.Chitietdonhangs
                .Include(c => c.MaDonNavigation)
                .Include(c => c.MaSanPhamNavigation)
                .FirstOrDefaultAsync(m => m.MaSanPham == id);
            if (chitietdonhang == null)
            {
                return NotFound();
            }

            return View(chitietdonhang);
        }

        // GET: Chitietdonhangs/Create
        public IActionResult Create()
        {
            ViewData["MaDon"] = new SelectList(_context.Donhangs, "MaDon", "MaDon");
            ViewData["MaSanPham"] = new SelectList(_context.Sanphams, "MaSanPham", "MaSanPham");
            return View();
        }

        // POST: Chitietdonhangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSanPham,MaDon,SoLuong,DonGia")] Chitietdonhang chitietdonhang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitietdonhang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaDon"] = new SelectList(_context.Donhangs, "MaDon", "MaDon", chitietdonhang.MaDon);
            ViewData["MaSanPham"] = new SelectList(_context.Sanphams, "MaSanPham", "MaSanPham", chitietdonhang.MaSanPham);
            return View(chitietdonhang);
        }

        // GET: Chitietdonhangs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietdonhang = await _context.Chitietdonhangs.FindAsync(id);
            if (chitietdonhang == null)
            {
                return NotFound();
            }
            ViewData["MaDon"] = new SelectList(_context.Donhangs, "MaDon", "MaDon", chitietdonhang.MaDon);
            ViewData["MaSanPham"] = new SelectList(_context.Sanphams, "MaSanPham", "MaSanPham", chitietdonhang.MaSanPham);
            return View(chitietdonhang);
        }

        // POST: Chitietdonhangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaSanPham,MaDon,SoLuong,DonGia")] Chitietdonhang chitietdonhang)
        {
            if (id != chitietdonhang.MaSanPham)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitietdonhang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChitietdonhangExists(chitietdonhang.MaSanPham))
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
            ViewData["MaDon"] = new SelectList(_context.Donhangs, "MaDon", "MaDon", chitietdonhang.MaDon);
            ViewData["MaSanPham"] = new SelectList(_context.Sanphams, "MaSanPham", "MaSanPham", chitietdonhang.MaSanPham);
            return View(chitietdonhang);
        }

        // GET: Chitietdonhangs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietdonhang = await _context.Chitietdonhangs
                .Include(c => c.MaDonNavigation)
                .Include(c => c.MaSanPhamNavigation)
                .FirstOrDefaultAsync(m => m.MaSanPham == id);
            if (chitietdonhang == null)
            {
                return NotFound();
            }

            return View(chitietdonhang);
        }

        // POST: Chitietdonhangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chitietdonhang = await _context.Chitietdonhangs.FindAsync(id);
            _context.Chitietdonhangs.Remove(chitietdonhang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChitietdonhangExists(string id)
        {
            return _context.Chitietdonhangs.Any(e => e.MaSanPham == id);
        }
    }
}
