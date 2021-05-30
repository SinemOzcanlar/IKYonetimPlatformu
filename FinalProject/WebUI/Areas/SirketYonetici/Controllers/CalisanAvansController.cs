using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;
using WebTestUI.Factories;
using System.Net.Http;

namespace WebTestUI.Areas.SirketYonetici.Controllers
{
    [Area("SirketYonetici")]
    public class CalisanAvansController : Controller
    {
        private readonly KolayIkContext _context;


        public CalisanAvansController(KolayIkContext context)
        {
            _context = context;
        }
        private int KullaniciId()
        {
            if (Request.Cookies["UserId"] == null)
            {
                return 0;
            }
            return int.Parse(Request.Cookies["UserId"]);
        }
        private int SirketId()
        {
            using HttpResponseMessage result = CalisanFactory.Factory.GetCalisanById(KullaniciId(), out Calisan calisan);
            return (int)calisan.SirketId;
        }

        // GET: SirketYonetici/CalisanAvans
        [Route("/SirketYonetici/CalisanAvans/index")]
        public async Task<IActionResult> Index()
        {
            var kolayIkContext = _context.CalisanAvanslar.Include(c => c.Calisan).Where(a=>a.Calisan.SirketId==SirketId());
            return View(await kolayIkContext.ToListAsync());
        }

        // GET: SirketYonetici/CalisanAvans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calisanAvans = await _context.CalisanAvanslar
                .Include(c => c.Calisan)
                .FirstOrDefaultAsync(m => m.CalisanAvansID == id);
            if (calisanAvans == null)
            {
                return NotFound();
            }

            return View(calisanAvans);
        }


        // GET: SirketYonetici/CalisanAvans/AvansOnay/5
        public IActionResult AvansOnay(int? id)
        {
            var avans = _context.CalisanAvanslar.Where(a => a.CalisanAvansID == id).FirstOrDefault();

            OnaylananAvans(avans);
            return RedirectToAction("index", "CalisanAvans");
        }
        void OnaylananAvans(CalisanAvans avans)
        {
            avans.OnayDurumu = Entities.Concrete.Enums.OnayDurumu.Onaylı;
            avans.AvansOnaylandıgıTarih = DateTime.Now;
            CalisanAvansFactory.Factory.Guncelle(avans.CalisanAvansID, avans);
        }
        void ReddedilenAvans(CalisanAvans avans)
        {
            avans.OnayDurumu = Entities.Concrete.Enums.OnayDurumu.Red;
            CalisanAvansFactory.Factory.Guncelle(avans.CalisanAvansID, avans);
        }

        public IActionResult AvansRed(int id, string RedAciklama)
        {
            var avansStatu = _context.CalisanAvanslar.Where(a => a.CalisanAvansID == id).FirstOrDefault();
            avansStatu.RedAciklama = RedAciklama;
            ReddedilenAvans(avansStatu);

            Bildirim bildirim = new Bildirim
            {
                Baslik = "Avansınız Reddedildi",
                CalisanId = avansStatu.CalisanID,
                Icerik = avansStatu.AvansMiktarı + " tutarındaki avans talebiniz " + DateTime.Now + " tarihinde şu sebepten ötürü reddedilmiştir.Sebep: " + RedAciklama,
                SablonVsBildirim = SablonVsBildirim.Bildirim,
                GonderilecekMi = false,
                GonderilmeTarihi = DateTime.Now
            };
            BildirimFactory.Factory.AddBildirim(bildirim);
            return RedirectToAction("index", "CalisanAvans");

        }

        // GET: SirketYonetici/CalisanAvans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calisanAvans = await _context.CalisanAvanslar
                .Include(c => c.Calisan)
                .FirstOrDefaultAsync(m => m.CalisanAvansID == id);
            if (calisanAvans == null)
            {
                return NotFound();
            }

            return View(calisanAvans);
        }

        // POST: SirketYonetici/CalisanAvans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calisanAvans = await _context.CalisanAvanslar.FindAsync(id);
            _context.CalisanAvanslar.Remove(calisanAvans);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalisanAvansExists(int id)
        {
            return _context.CalisanAvanslar.Any(e => e.CalisanAvansID == id);
        }

        public ActionResult GetBelirsizAvansSayisi()
        {
            CalisanFactory.Factory.GetCalisanlar(out IEnumerable<Calisan> calisanlar);
            CalisanAvansFactory.Factory.GetAvanslar(out IEnumerable<CalisanAvans> avanslar);
            avanslar = avanslar.Where(a => a.OnayDurumu == Entities.Concrete.Enums.OnayDurumu.Belirsiz).ToList();
            var count = avanslar.Count();
            var data2 = new { count };
            return Json(data2);
        }
    }
}
