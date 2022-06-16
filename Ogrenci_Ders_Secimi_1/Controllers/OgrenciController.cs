using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ogrenci_Ders_Secimi.Models;
using Ogrenci_Ders_Secimi_1.Models;
using Ogrenci_Ders_Secimi_1.Models.Concrete.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly OgrenciDersSabahContext _context;

        public OgrenciController(OgrenciDersSabahContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Ogrenciler.ToList());
        }

        public IActionResult Details(int id)
        {
            var ogrenci = _context.Ogrenciler.Find(id);
            return View(ogrenci);
        }

        public IActionResult Create()
        {
            ViewData["Bolum"] = new SelectList(_context.Bolumler, "BolumId", "BolumAd");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ogrenci ogrenci)
        {
            _context.Add(ogrenci);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewData["Bolum"] = new SelectList(_context.Bolumler, "BolumId", "BolumAd");
            var ogrenci = _context.Ogrenciler.Find(id);
            return View(ogrenci);
        }

        [HttpPost]
        public IActionResult Edit(Ogrenci ogrenci)
        {
            if (!ModelState.IsValid)
            {
                return View(ogrenci);
            }
            _context.Update(ogrenci);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var ogrenci = _context.Ogrenciler.Find(id);
            return View(ogrenci);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekOgrenci = _context.Ogrenciler.Find(id);
            _context.Remove(silinecekOgrenci);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AssignLesson()
        {
            var model = new EFCoreOgrenciDAL();
            return View(model.GetAll());
        }

        public IActionResult Assign(int id)
        {
            var model2 = new EFCoreDersDAL();
            var context = new EFCoreOgrenciDAL();
            var entity = context.GetByIdWithDersler(id);
            var model = new OgrenciModel()
            {
                OgrenciId = entity.OgrenciId,
                OgrenciNo = entity.OgrenciNo,
                OgrenciAd = entity.OgrenciAd,
                OgrenciSoyAd = entity.OgrenciSoyAd,
                OgrenciDogumTarihi = entity.OgrenciDogumTarihi,
                OgrenciKayitTarihi = entity.OgrenciKayitTarihi,
                OgrenciDonemi = entity.OgrenciDonemi,
                BolumId = entity.BolumId,
                SecilenDersler = entity.OgrenciDersler.Select(x => x.Ders).ToList()
            };
            ViewBag.Dersler = model2.GetAll();
            return View(model);
        }

    }
}
