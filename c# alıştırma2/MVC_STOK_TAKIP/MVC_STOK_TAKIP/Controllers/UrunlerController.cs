using MVC_STOK_TAKIP.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_STOK_TAKIP.Controllers
{
    public class UrunlerController : Controller
    {
        DbMvcStockEntities db = new DbMvcStockEntities();

        public ActionResult Index(string p)
        {
            //var kategori = db.TBL_URUN.Where(X=>X.DURUM==true).ToList();
            var urunler = db.TBL_URUN.Where(x => x.DURUM == true);  
            if (!string.IsNullOrEmpty(p))
            {
                urunler = urunler.Where(x=>x.AD.Contains(p));


            }


            return View(urunler.ToList());
        }

        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> gelen_kategori = new List<SelectListItem>();
            gelen_kategori = (from i in db.TBL_KATEGORI.ToList()
                             select new SelectListItem
                             {
                                 Text=i.AD,
                                 Value=i.ID.ToString(),
                             }).ToList();
            ViewBag.gelen = gelen_kategori;
            return View();
        }

        [HttpPost]
        public ActionResult YeniUrun(TBL_URUN p)
        {
            var kategori  = db.TBL_KATEGORI.Where(i=>i.ID==p.TBL_KATEGORI.ID).FirstOrDefault();
            p.TBL_KATEGORI = kategori;
            db.TBL_URUN.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Sil(TBL_URUN P)
        {
            var urun = db.TBL_URUN.Find(P.ID);
            urun.DURUM = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> urn = (from i in db.TBL_KATEGORI.ToList()

                                        select new SelectListItem
                                        {
                                            Text = i.AD,
                                            Value = i.ID.ToString(),
                                        }).ToList();


            ViewBag.urun_kat=urn;
            
            var urun = db.TBL_URUN.Find(id);
            return View("UrunGetir",urun);
        }

        public ActionResult Guncelle(TBL_URUN p)
        {
            var urun = db.TBL_URUN.Find(p.ID);
            urun.AD = p.AD;
            urun.MARKA = p.MARKA;
            urun.STOK = p.STOK;
            urun.ALIS_FIYAT = p.ALIS_FIYAT;
            urun.SATIS_FIYAT = p.SATIS_FIYAT;
            var ktg = db.TBL_KATEGORI.Where(i => i.ID == p.TBL_KATEGORI.ID).FirstOrDefault();
            urun.KATEGORI_ID = ktg.ID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}