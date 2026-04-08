using Antlr.Runtime.Tree;
using OgrenciMVCProje.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciMVCProje.Controllers
{
    public class OgrenciController : Controller
    {
        BonusOkulEntities bns = new BonusOkulEntities();
        // GET: Ogrenci
        public ActionResult Index()
        {

            var Ogr = bns.TBL_OGR.ToList();
            return View(Ogr);
        }

        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            List<SelectListItem> degerler =(from i in bns.TBL_KULUP.ToList()
                                            
                                            select new SelectListItem
                                            {
                                                Text= i.KULUP_ADI,
                                                Value=i.KULUP_ID.ToString()
                                            }).ToList();
                                            
                                            ViewBag.dgr = degerler;



            return View();
        }
        
        [HttpPost]
        public ActionResult YeniOgrenci(TBL_OGR p)
        {
            /*
             Where(i => i.KULUP_ID == p.TBL_KULUP.KULUP_ID) ifadesi, TBL_KULUP tablosunda KULUP_ID değeri p.TBL_KULUP.KULUP_ID ile eşleşen kaydı arar. 
             p.TBL_KULUP.KULUP_ID, formdan gelen öğrenci nesnesindeki kulüp ID'sini temsil eder.
             
             */

            var klp = bns.TBL_KULUP.Where(i=>i.KULUP_ID==p.TBL_KULUP.KULUP_ID).FirstOrDefault();

            /*
             Bu işlem, öğrenciye ait TBL_KULUP nesnesinin (yani öğrencinin kulüp bilgisi) tam ve doğru verilerle dolmasını sağlar.
             */
            p.TBL_KULUP= klp;

            bns.TBL_OGR.Add(p);
            bns.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult Sil(int id)
        {
            bns.TBL_OGR.Remove(bns.TBL_OGR.Find(id));
            bns.SaveChanges();
            return RedirectToAction("Index");


        }

        public ActionResult OgrenciGetir(int id)
        {
            var ogrenci = bns.TBL_OGR.Find(id);
            List<SelectListItem> degerler = (from i in bns.TBL_KULUP.ToList()

                                             select new SelectListItem
                                             {
                                                 Text = i.KULUP_ADI,
                                                 Value = i.KULUP_ID.ToString()
                                             }).ToList();

            ViewBag.dgr = degerler;
            return View("OgrenciGetir",ogrenci);

        }

        public ActionResult Guncelle(TBL_OGR p)
        {
            var ogr = bns.TBL_OGR.Find(p.OGRID);
            ogr.OGRAD = p.OGRAD;
            ogr.OGRSOYAD = p.OGRSOYAD;
            ogr.OGRCINSIYET = p.OGRCINSIYET;
            ogr.OGRFOTO= p.OGRFOTO;
            ogr.OGRKULUP = p.OGRKULUP;
            bns.SaveChanges();
            return RedirectToAction("Index","Ogrenci");

        }


    }
}