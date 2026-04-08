using OgrenciMVCProje.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciMVCProje.Controllers
{
    public class KulüpController : Controller
    {
        BonusOkulEntities bns = new BonusOkulEntities();
        // GET: Kulüp
        public ActionResult Index()
        {
            var kulüp = bns.TBL_KULUP.ToList();
            return View(kulüp);
        }

        [HttpGet]
        public ActionResult YeniKulüp()
        {

            return View();

        }

        [HttpPost]
        public ActionResult YeniKulüp(TBL_KULUP p)
        {
            bns.TBL_KULUP.Add(p);
            bns.SaveChanges();
            return View();


        }



        public ActionResult Sil(int id)
        {
           bns.TBL_KULUP.Remove(bns.TBL_KULUP.Find(id));
            bns.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult KulüpGetir(int id)
        {
            var kulup = bns.TBL_KULUP.Find(id);
            return View("KulüpGetir",kulup);
        }



        public ActionResult Guncelle(TBL_KULUP p)
        {
            var klp = bns.TBL_KULUP.Find(p.KULUP_ID);
            klp.KULUP_ADI = p.KULUP_ADI;
            bns.SaveChanges();
            return RedirectToAction("Index","Kulüp");


        }




    }
}