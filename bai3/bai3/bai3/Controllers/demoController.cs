using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai3.Models;

namespace bai3.Controllers
{
    public class demoController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TinhTong(string soA, string soB)
        {
            int SoThuNha = Convert.ToInt32(soA);
            int SoThuHai = Convert.ToInt32(soB);
            int TongHaiSo = gpt.TinhTong(SoThuNha, SoThuHai);
            ViewBag.Tong = TongHaiSo;
            return View();

        }
    }
}