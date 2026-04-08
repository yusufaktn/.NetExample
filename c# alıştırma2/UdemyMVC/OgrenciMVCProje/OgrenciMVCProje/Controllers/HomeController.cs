using OgrenciMVCProje.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciMVCProje.Controllers
{
    public class HomeController : Controller
    {
        BonusOkulEntities bns = new BonusOkulEntities();
        // GET: Default
        public ActionResult Index()
        {
            
            var ders = bns.TBL_DERSLER.ToList();
            return View(ders);
        }


        [HttpGet]
        public ActionResult YeniDersEkle()
        {

            
            return View();

        }

        [HttpPost]
        public ActionResult YeniDersEkle(TBL_DERSLER p) {
        
            bns.TBL_DERSLER.Add(p);
            bns.SaveChanges();
            return View();
        
        }


        public ActionResult Sil(int id)
        {
           bns.TBL_DERSLER.Remove( bns.TBL_DERSLER.Find(id));
            bns.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DersGetir(int id)
        {

            var ders = bns.TBL_DERSLER.Find(id);
            return View("DersGetir", ders);


        }

        public ActionResult Guncelle(TBL_DERSLER p)
        {
            var ders = bns.TBL_DERSLER.Find(p.DERSID);
            ders.DERSAD= p.DERSAD;
            ders.DERSKREDI = p.DERSKREDI;
            bns.SaveChanges();
            return RedirectToAction("Index","Home");





        }

    }
}