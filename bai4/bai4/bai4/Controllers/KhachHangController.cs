using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai4.Models;

namespace bai4.Controllers
{
    public class KhachHangController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();
        // GET: Student
        public ActionResult Index()
        {
            var model = db.KhachHangs.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}