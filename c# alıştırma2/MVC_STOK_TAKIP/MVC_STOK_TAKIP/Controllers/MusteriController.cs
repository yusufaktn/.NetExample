using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_STOK_TAKIP.Models.Entity;
using PagedList;
using PagedList.Mvc;
namespace MVC_STOK_TAKIP.Controllers
{
    public class MusteriController : Controller
    {

        DbMvcStockEntities db = new DbMvcStockEntities();

        [Authorize]
        public ActionResult Index(int sayfa = 1)
        {
            //var musteri = db.TBL_MUSTERI.ToList();
            var musteri = db.TBL_MUSTERI.Where(x => x.DURUM == true).ToList().ToPagedList(sayfa, 3);
            return View(musteri);
        }

        [HttpGet]
        public ActionResult YeniMusteri()
        {

            return View();

        }

        [HttpPost]
        public ActionResult YeniMusteri(TBL_MUSTERI p)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMusteri");

            }


            p.DURUM = true;
            db.TBL_MUSTERI.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult MusteriSil(int id)
        {
            var musteri = db.TBL_MUSTERI.Find(id);
            musteri.DURUM = false;
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult MusteriGetir(int id)
        {

            var musteri = db.TBL_MUSTERI.Find(id);
            return View("MusteriGetir",musteri);

        }


        public ActionResult MusteriGuncelle(TBL_MUSTERI p)
        {
             var musteri =db.TBL_MUSTERI.Find(p.ID);
            musteri.AD=p.AD;
            musteri.SOYAD=p.SOYAD;
            musteri.BAKIYE=p.BAKIYE;
            musteri.SEHIR=p.SEHIR;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }


}