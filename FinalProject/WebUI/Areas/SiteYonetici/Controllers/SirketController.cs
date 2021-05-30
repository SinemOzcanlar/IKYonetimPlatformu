using DataAccess.Concrete.EntityFramework;
using DataAccess.ViewModels;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WebTestUI.Factories;

namespace WebTestUI.Areas.SiteYonetici.Controllers
{
    [Area("SiteYonetici")]
    public class SirketController : Controller
    {
        private readonly KolayIkContext _context;
        private readonly IWebHostEnvironment Environment;

        public SirketController(KolayIkContext context,IWebHostEnvironment _Environment)
        {
            _context = context;
            Environment = _Environment;
        }
        public IActionResult Index()
        {
            return View();
        }

        //Get
        public IActionResult Create()
        {
            List<SelectListItem> listItems = (from i in _context.UyelikPlanilari select new SelectListItem { Text = i.UyelikPlaniTanimi, Value = i.UyelikPlaniID.ToString() }).ToList();

            ViewBag.dgr = listItems;

            return View();
        }

        [HttpPost]
        public IActionResult Create(SirketViewModel sirket)
        {

            List<SelectListItem> listItems = (from i in _context.UyelikPlanilari select new SelectListItem { Text = i.UyelikPlaniTanimi, Value = i.UyelikPlaniID.ToString() }).ToList();

            ViewBag.dgr = listItems;

            Sirket sirket1 = new Sirket();
            string resimler = Path.Combine(this.Environment.WebRootPath, "SirketLogo");
            if (sirket.ResimDosyasi != null)
            {
                using (var fileStream = new FileStream(Path.Combine(resimler, sirket.ResimDosyasi.FileName), FileMode.Create))
                {
                    sirket.ResimDosyasi.CopyToAsync(fileStream);
                }
                sirket1.Logo = sirket.ResimDosyasi.FileName;
            }
            
            sirket1.ResimDosyasi = null;
            sirket1.Adi = sirket.SirketAdi;
            sirket1.CreatedDate = DateTime.Now;
           
            _context.Sirketler.Add(sirket1);
            _context.SaveChanges();

            int id = sirket.UyelikPlani.UyelikPlaniID;

            UyelikPlaniFactory.Factory.GetUyelikPlaniById(id, out UyelikPlani uyelikPlani);

            SirketUyelikPlani sirketUyelik = new SirketUyelikPlani
            {
                Sirket = sirket1,
                UyelikPlani = uyelikPlani,
                CreatedDate = DateTime.Now,
                IsActive = true,
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddYears(1)
            };
            SirketUyelikPlaniFactory.Factory.AddPlan(sirketUyelik);

            sirket1.SirketUyelikPlaniId = sirketUyelik.SirketUyelikPlaniID;
            SirketFactory.Factory.Guncelle(sirket1.SirketId,sirket1);

            Calisan calisan = new Calisan
            {
                DogumTarihi = sirket.YoneticiDogumTarihi,
                Adi = sirket.YoneticiAdi,
                Soyadi = sirket.YoneticiSoyadi,
                MailIs = sirket.YoneticiEmail,
                MailKisisel = sirket.YoneticiEmail,
                SirketId = sirket1.SirketId,
                ErisimTuru = Entities.Concrete.Enums.ErisimTuru.Yonetici,
                IseGirisTarihi = DateTime.Now,
                SozlesmeTuru = Entities.Concrete.Enums.SozlesmeTuru.Suresiz,
                CreatedDate = DateTime.Now,
                CocukSayisi = 0
            };

            CalisanFactory.Factory.AddCalisan(calisan);  
            SifreGonder();

            return RedirectToAction("Index", "Home");
        }

        private static string RandomPassword(int length)
        {
            string allowed = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(allowed
                .OrderBy(o => Guid.NewGuid())
                .Take(length)
                .ToArray());
        }
        private void SifreGonder()
        {
            Random random = new Random();
            Calisan calisan = SonEklenenCalisan();
            Sifre sifre = new Sifre
            {
                OlusturulmaTarihi = DateTime.Now,
                CalisanId = calisan.CalisanId,
                CreatedDate = DateTime.Now,
                Parola = RandomPassword(random.Next(8, 12))
            };
            SifreFactory.Factory.AddSifre(sifre);
            SmtpClient sc = new SmtpClient
            {
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Credentials = new NetworkCredential("dragunov199137@gmail.com", "741852963Ab")
            };
            MailMessage mail = new MailMessage
            {
                From = new MailAddress("dragunov199137@gmail.com")
            };
            mail.To.Add(calisan.MailIs);
            mail.To.Add(calisan.MailKisisel);
            mail.Subject = "Aramıza hoşgeldiniz.";
            mail.IsBodyHtml = true;
            mail.Body = "Siteye " + calisan.MailIs + " adresiyle ve   " + sifre.Parola + "  şifresiyle giriş yapabilirsiniz.Lütfen güvenliğiniz açısından ilk giriş yaptığınızda şifrenizi değiştiriniz.";
            sc.Send(mail);
        }

        private Calisan SonEklenenCalisan()
        {
            CalisanFactory.Factory.GetCalisanlar(out IEnumerable<Calisan> calisanlar);
            return calisanlar.OrderByDescending(a => a.CreatedDate).FirstOrDefault();
        }

    }
}
