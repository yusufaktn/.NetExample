using KutuphaneOtomasyonMVC.Models;
using KutuphaneOtomasyonMVC.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneOtomasyonMVC.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly KutuphaneContext _context;

        public KullaniciController(KutuphaneContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var kullanicilar =_context.Kullanicilar.ToList();
            return View(kullanicilar);
        }

        [HttpGet]
        public IActionResult YeniKullanici()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniKullanici(Kullanici kullanici)
        {
            _context.Kullanicilar.Add(kullanici);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Duzenle(int id)
        {
            var kullaniciBul = _context.Kullanicilar.Find(id);
            return View(kullaniciBul);
        }

        [HttpPost]
        public IActionResult Duzenle(Kullanici k)
        {
            var kullanici = _context.Kullanicilar.Find(k.KullaniciID);
            kullanici.Ad = k.Ad;
            kullanici.Soyad = k.Soyad;
            kullanici.Eposta = k.Eposta;
            kullanici.Rol = k.Rol;
            _context.SaveChanges();
            return RedirectToAction("Index","Kullanici");
        }

        public IActionResult Sil(int id)
        {
            var kullanici = _context.Kullanicilar.Find(id);
            if (kullanici != null)
            {
                _context.Kullanicilar.Remove(kullanici);
                _context.SaveChanges();
            }
            return RedirectToAction("Index","Kullanici");
        }

    }
}
