using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoQLDD.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: NguoiDung
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Dangky()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Dangnhap()
        {
            return View();
        }
    }
}