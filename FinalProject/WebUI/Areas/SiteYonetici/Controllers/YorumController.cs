using DataAccess.Concrete.EntityFramework;
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
    public class YorumController : Controller
    {
        public IActionResult Index()
        {
            KullaniciYorumFactory.Factory.GetYorumlar(out IEnumerable<KullaniciYorumu> yorumular);
            foreach (var item in yorumular)
            {
                CalisanFactory.Factory.GetCalisanById(item.CalisanId, out Calisan calisan);
                item.Calisan = calisan;
            }
            return View(yorumular);
        }

        public ActionResult GetOkunmamışYorumSayisi()
        {
            KullaniciYorumFactory.Factory.GetYorumlar(out IEnumerable<KullaniciYorumu> yorumular);
            yorumular = yorumular.Where(a => a.OkunduMu == false).ToList();
            var count = yorumular.Count();
            var data = new { count };
            return Json(data);
        }
        public IActionResult YorumDetay(int id)
        {
            KullaniciYorumFactory.Factory.GetYorumById(id, out KullaniciYorumu yorum);
            yorum.OkunduMu = true;
            KullaniciYorumFactory.Factory.Guncelle(id, yorum);


            return View(yorum);

        }

    }
}
