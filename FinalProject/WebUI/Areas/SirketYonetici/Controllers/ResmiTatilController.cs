using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebTestUI.Factories;

namespace WebTestUI.Areas.SirketYonetici.Controllers
{
    public class ResmiTatilController : Controller
    {
        // GET: ResmiTatilController
        public ActionResult Index()
        {
            return View();
        }

    }
}
