using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai2.Models;

namespace bai2.Controllers
{
    public class DemoController : Controller
    {
        giaiphuongtrinh gpt = new giaiphuongtrinh();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult gptb1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult gptb1(double hesoA, double hesoB)
        {
            double x = gpt.giaiphuongtrinhbacnhat(hesoA, hesoB);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}