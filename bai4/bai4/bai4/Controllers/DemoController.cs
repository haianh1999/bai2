using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai4.Models;

namespace bai4.Controllers
{
    public class DemoController : Controller
    {
     
        GiaiPhuongTrinhBacNhat gpt = new GiaiPhuongTrinhBacNhat();
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
       public ActionResult DemoControlerGiaiPhuongtrinhBacNhatt(string soA, string soB)
        {
            double a = double.Parse(soA);
            double b = double.Parse(soB);
            double x = gpt.GiaiPhuongTrinhBacNhatt(a,b);
            ViewBag.NghiemPT = x;
            return View();
        }

    }
}