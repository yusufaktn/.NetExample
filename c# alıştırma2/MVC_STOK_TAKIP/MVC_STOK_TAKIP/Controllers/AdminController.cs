using MVC_STOK_TAKIP.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_STOK_TAKIP.Controllers
{
    public class AdminController : Controller
    {
        DbMvcStockEntities db = new DbMvcStockEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult YeniAdmin()
        {

            return View();

        }
        [HttpPost]
        public ActionResult YeniAdmin(TBL_ADMIN p)
        {


            return RedirectToAction("Index");
        }

    }
}