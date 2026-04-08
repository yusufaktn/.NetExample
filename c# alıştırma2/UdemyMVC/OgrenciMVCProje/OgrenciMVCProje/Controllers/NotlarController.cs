using Antlr.Runtime;
using Antlr.Runtime.Tree;
using OgrenciMVCProje.Models;
using OgrenciMVCProje.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciMVCProje.Controllers
{
    public class NotlarController : Controller
    {
        BonusOkulEntities bns = new BonusOkulEntities();
        // GET: Notlar
        public ActionResult Index()
        {
            var notlar = bns.TBL_NOTLAR.ToList();
            return View(notlar);
        }


        [HttpGet]
        public ActionResult YeniNotlar()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniNotlar(TBL_NOTLAR not)
        {
            if (ModelState.IsValid)
            {
                bns.TBL_NOTLAR.Add(not);
                bns.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(not);
        }



        public ActionResult NotGetir(int id)
        {
            var not = bns.TBL_NOTLAR.Find(id);
            return View("NotGetir", not);

        }


        [HttpPost]
        public ActionResult NotGetir(TBL_NOTLAR p, int sinav1, int sinav2, int proje, Class1 model)
        {
            if (model.islem == "HESAPLA")
            {
                string durum;
                int ort = (sinav1 + sinav2 + proje) / 3;
                if (ort < 50)
                {
                     durum = "False";


                }
                else
                {
                    durum="True";
                }
                ViewBag.durum = durum;
                ViewBag.ort = ort;


            }
            if(model.islem == "GUNCELLE")
            {

                var not = bns.TBL_NOTLAR.Find(p.NOTID);
                not.DERSID=p.DERSID;
                not.SINAV1 = p.SINAV1;
                not.SINAV2 = p.SINAV2;
                not.PROJE = p.PROJE;
                not.ORTALAMA = p.ORTALAMA;
                not.DURUM = p.DURUM;
                bns.SaveChanges();
                return RedirectToAction("Index","Notlar");


            }

            return View();

        }



    }
}