using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTestUI.Factories;

namespace WebTestUI.Areas.SiteYonetici.Controllers
{
    [Area("SiteYonetici")]
    public class UyelikPlaniController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<UyelikPlani> planlar = UyelikPlanlariniGetir();
            return View(planlar);
        }
        public IActionResult UyelikPasif(int id)
        {
            SirketUyelikPlaniFactory.Factory.GetPlanById(id, out SirketUyelikPlani plan);
            plan.IsActive = false;
            SirketUyelikPlaniFactory.Factory.Guncelle(id,plan);
            return RedirectToAction("Index","Home");
        }
        public IEnumerable<UyelikPlani> UyelikPlanlariniGetir() 
        {
            UyelikPlaniFactory.Factory.GetUyelikPlanlari(out IEnumerable<UyelikPlani> UyelikPlanlari);
            return UyelikPlanlari;
        }
        public IActionResult Create()
        {
            return View(new UyelikPlani());
        }

        [HttpPost]
        public IActionResult Create(UyelikPlani uyelikPlani)
        {
            if (ModelState.IsValid)
            {
                uyelikPlani.CreatedDate = DateTime.Now;
                uyelikPlani.SirketUyelikPlani = null;
                UyelikPlaniFactory.Factory.UyelikPlaniEkle(uyelikPlani);
                return View("Index", UyelikPlanlariniGetir());
            }
            return View(uyelikPlani);
        }

        public IActionResult Edit(int id)
        {
            UyelikPlaniFactory.Factory.GetUyelikPlaniById(id, out UyelikPlani uyelikPlani);
            return View(uyelikPlani);
        }

        [HttpPost]
        public IActionResult Edit(int id, UyelikPlani uyelikPlani)
        {
            if (id!=uyelikPlani.UyelikPlaniID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                UyelikPlaniFactory.Factory.Guncelle(id, uyelikPlani);

                }
                catch (Exception ex)
                {                   
                    throw new Exception(ex.Message);
                }
                return View("Index",UyelikPlanlariniGetir());
            }
            return View(uyelikPlani);
        }
        public IActionResult Sil(int id)
        {
            UyelikPlaniFactory.Factory.GetUyelikPlaniById(id, out UyelikPlani uyelikPlani);
            return View(uyelikPlani);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult SilOnay(int id)
        {
            UyelikPlaniFactory.Factory.Sil(id);
            return View("Index", UyelikPlanlariniGetir());
        }
    }
}
