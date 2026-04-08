using MVC_STOK_TAKIP.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_STOK_TAKIP.Controllers
{
    public class SatislarController : Controller
    {
      DbMvcStockEntities db = new DbMvcStockEntities();

        public ActionResult Index()
        {
            var satis = db.TBL_SATIS.ToList();
            return View(satis);
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            //ÜRün
            List<SelectListItem> ürün = new List<SelectListItem>();
            ürün = (from i in db.TBL_URUN.ToList()
                              select new SelectListItem
                              {
                                  Text = i.AD,
                                  Value = i.ID.ToString(),
                              }).ToList();
            ViewBag.urun = ürün;

            //müşteri

            List<SelectListItem> müsteri = new List<SelectListItem>();
            müsteri = (from i in db.TBL_MUSTERI.ToList()
                       select new SelectListItem
                       {
                           Text = i.AD,
                           Value = i.ID.ToString(),
                       }).ToList();
            ViewBag.müsteri = müsteri;



            //personel

            List<SelectListItem> personel = new List<SelectListItem>();
            personel = (from i in db.TBL_PERSONEL.ToList()
                        select new SelectListItem
                        {
                            Text = i.AD,
                            Value = i.ID.ToString(),
                        }).ToList();
            ViewBag.personel = personel;


            return View();
        }


        [HttpPost]
        public ActionResult YeniSatis(TBL_SATIS p)
        {
            var urun = db.TBL_URUN.Where(x=>x.ID == p.TBL_URUN.ID).FirstOrDefault();
            var musteri = db.TBL_MUSTERI.Where(x => x.ID == p.TBL_MUSTERI.ID).FirstOrDefault();
            var personel = db.TBL_PERSONEL.Where(x => x.ID == p.TBL_PERSONEL.ID).FirstOrDefault();
            p.TBL_URUN = urun;
            p.TBL_MUSTERI = musteri;
            p.TBL_PERSONEL = personel;

            db.TBL_SATIS.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }

}