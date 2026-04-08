using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_STOK_TAKIP.Models.Entity;

namespace MVC_STOK_TAKIP.Controllers
{
    public class KategoriController : Controller
    {
        DbMvcStockEntities db = new DbMvcStockEntities();

        public ActionResult Index()
        {
            var kategori = db.TBL_KATEGORI.ToList();
            return View(kategori);
        }


        [HttpGet]
        public ActionResult YeniKategori()
        {

            return View();
        }

        [HttpPost]
        public ActionResult YeniKategori(TBL_KATEGORI p)
        {

            db.TBL_KATEGORI.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult KategoriSil(int id)
        {
            var kategori = db.TBL_KATEGORI.Find(id);
            db.TBL_KATEGORI.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");


        }

        public ActionResult KategoriGetir(int id)
        {
            var kategori = db.TBL_KATEGORI.Find(id);
           return View("KategoriGetir",kategori);


        }

        public ActionResult Guncelle(TBL_KATEGORI p)
        {
           var kategori= db.TBL_KATEGORI.Find(p.ID);
            kategori.AD = p.AD;
            db.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}