using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KutuphaneOtomasyonMVC.Models;
using KutuphaneOtomasyonMVC.Models.Data;

namespace KutuphaneOtomasyonMVC.Controllers
{
    public class KitaplarController : Controller
    {
        private readonly KutuphaneContext _context;

        
        public KitaplarController(KutuphaneContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {      
            var kitaplar =  _context.Kitaplar.ToList();
            return View(kitaplar);
        }

        [HttpGet]
        public IActionResult YeniKitap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniKitap(Kitap kitap)
        {
            _context.Kitaplar.Add(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Duzenle(int id)
        {
            var kitapBul = _context.Kitaplar.Find(id);
            return View(kitapBul);


        }

        [HttpPost]
        public IActionResult Duzenle(Kitap k)
        {
            var kitap =_context.Kitaplar.Find(k.KitapID);
            kitap.ISBN = k.ISBN;
            kitap.Baslik = k.Baslik;
            kitap.Yazar = k.Yazar;
            kitap.YayinYili = k.YayinYili;
            _context.SaveChanges();


            return RedirectToAction("Index","Kitaplar");
        }


        public IActionResult Sil(int id)
        {
            var kitap = _context.Kitaplar.Find(id);
            if (kitap != null)
            {
                _context.Kitaplar.Remove(kitap);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
