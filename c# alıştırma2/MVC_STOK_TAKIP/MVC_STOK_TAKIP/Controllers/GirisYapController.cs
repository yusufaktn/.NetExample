using MVC_STOK_TAKIP.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_STOK_TAKIP.Controllers
{
    public class GirisYapController : Controller
    {

        DbMvcStockEntities db = new DbMvcStockEntities();
        // GET: GirisYap
        public ActionResult Giris()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Girisyap(TBL_ADMIN p)
        {
            var bilgiler = db.TBL_ADMIN.FirstOrDefault(x => x.AD == p.AD && x.SIFRE == p.SIFRE);

            if (bilgiler != null)
            {

                FormsAuthentication.SetAuthCookie(bilgiler.AD, false);
                return RedirectToAction("Index", "Musteri");

            }
            else
            {
                return View();
            }


            



        }

    }
}