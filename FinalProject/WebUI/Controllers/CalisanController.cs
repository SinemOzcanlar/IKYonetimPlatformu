using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.ViewModels;
using System.Net.Http;
using WebTestUI.Factories;

namespace WebTestUI.Controllers
{
    public class CalisanController : Controller
    {
        private readonly EfCalisanKariyerDal efCalisanKariyerDal;

        public CalisanController(KolayIkContext context)
        {
            efCalisanKariyerDal = new EfCalisanKariyerDal(context);
        }
        
        private Calisan CalisanGetir(int id)
        {
            HttpResponseMessage result = CalisanFactory.Factory.GetCalisanById(id, out Calisan calisan);
            if (!result.IsSuccessStatusCode) ModelState.AddModelError(result.StatusCode.ToString(), result.ReasonPhrase);
            return calisan;
        }


        private int KullaniciId()
        {
            if (Request.Cookies["UserId"] == null)
            {
                return 0;
            }
            return int.Parse(Request.Cookies["UserId"]);
        }
        private IEnumerable<Calisan> CalisanlariGetir()
        {
            HttpResponseMessage result = CalisanFactory.Factory.GetCalisanlar(out IEnumerable<Calisan> Calisanlar);
            if (!result.IsSuccessStatusCode) ModelState.AddModelError(result.StatusCode.ToString(), result.ReasonPhrase);
            return Calisanlar;
        }
        public IActionResult Index()
        {            
            return View(CalisanlariGetir());
        }

        public IActionResult CalisanGoruntuleme(string ara)
        {
            int id = KullaniciId();
            if (id== 0) return NotFound();
            Calisan calisan = CalisanGetir(id);
            IEnumerable<Calisan> calisanlar = CalisanlariGetir();
            calisanlar = calisanlar.Where(a => a.SirketId == calisan.SirketId);
           
            if (!string.IsNullOrEmpty(ara))
            {
                calisanlar = calisanlar.Where(x => x.Adi.Contains(ara) || x.Soyadi.Contains(ara)).ToList();
            }
            return View(calisanlar);
        }

        public IActionResult CalisanEgitimGoruntuleme(int id) 
        {
            int Id = KullaniciId();
            if (Id == 0) return NotFound();
            CalisanEgitimViewModel model = new CalisanEgitimViewModel
            {
                Calisan = CalisanGetir(id)
            };
            model.CalisanId = model.Calisan.CalisanId;
            model.EgitimBilgileri = CalisanEgitimleriGetir().Where(a => a.CalisanId == id).ToList();
            return View(model);
        }
        private IEnumerable<EgitimBilgi> CalisanEgitimleriGetir()
        {
            HttpResponseMessage result = CalisanEgitimFactory.Factory.GetEgitimBilgileri(out IEnumerable<EgitimBilgi> EgitimBilgileri);
            if (!result.IsSuccessStatusCode) ModelState.AddModelError(result.StatusCode.ToString(), result.ReasonPhrase);
            return EgitimBilgileri;
        }
        public IActionResult CalisanKariyerGoruntuleme(int id)
        {
            int Id = KullaniciId();
            if (Id == 0) return NotFound();

            var calisan = CalisanGetir(id);
            var kariyer = efCalisanKariyerDal.GetAll(a => a.CalisanId == calisan.CalisanId);
           
            return View(kariyer);
        }

        public IActionResult Harcamalar()        
        {
            int id = KullaniciId();
            if (id == 0) return NotFound();
            HttpResponseMessage result = CalisanHarcamaFactory.Factory.GetHarcamalar(out IEnumerable<CalisanHarcama> harcamalar);
            if (!result.IsSuccessStatusCode) ModelState.AddModelError(result.StatusCode.ToString(), result.ReasonPhrase);
            return View(harcamalar.Where(a=>a.CalisanId==id));
        }

    }
}
