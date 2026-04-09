using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Film_Koleksiyonu_MVC.Models;
using System.Security.Claims;

namespace Film_Koleksiyonu_MVC.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProfileController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var userId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var user = _context.Users.Find(userId);
            return View(user);
        }

        public IActionResult Edit()
        {
            var userId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var user = _context.Users.Find(userId);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(IFormFile profileImage, string username, string currentPassword, string newPassword)
        {
            var userId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var user = _context.Users.Find(userId);

            if (user == null)
            {
                return NotFound();
            }

            // Profil fotoğrafı yükleme işlemi
            if (profileImage != null)
            {
                // Dosya uzantısını kontrol et
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
                var fileExtension = Path.GetExtension(profileImage.FileName).ToLowerInvariant();

                if (!allowedExtensions.Contains(fileExtension))
                {
                    ModelState.AddModelError("profileImage", "Sadece JPG ve PNG formatında resim yükleyebilirsiniz.");
                    return View(user);
                }

                // Dosya boyutunu kontrol et (2MB)
                if (profileImage.Length > 2 * 1024 * 1024)
                {
                    ModelState.AddModelError("profileImage", "Dosya boyutu 2MB'dan büyük olamaz.");
                    return View(user);
                }

                // Eski resmi sil
                if (!string.IsNullOrEmpty(user.ProfileImageUrl))
                {
                    var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, user.ProfileImageUrl.TrimStart('/'));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                // Yeni resmi kaydet
                var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Upload", "Profiles");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var uniqueFileName = $"{userId}_{DateTime.Now.Ticks}{fileExtension}";
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await profileImage.CopyToAsync(fileStream);
                }

                user.ProfileImageUrl = "/Upload/Profiles/" + uniqueFileName;
            }

            // Kullanıcı adı güncelleme
            if (!string.IsNullOrEmpty(username))
            {
                user.Username = username;
            }

            // Şifre güncelleme
            if (!string.IsNullOrEmpty(currentPassword) && !string.IsNullOrEmpty(newPassword))
            {
                if (user.Password != currentPassword)
                {
                    ModelState.AddModelError("currentPassword", "Mevcut şifre yanlış.");
                    return View(user);
                }

                user.Password = newPassword;
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // Film resmi yükleme yardımcı metodu
        public static async Task<string> UploadMovieImage(IFormFile imageFile, IWebHostEnvironment webHostEnvironment)
        {
            if (imageFile == null || imageFile.Length == 0)
                return null;

            // Dosya uzantısını kontrol et
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
            var fileExtension = Path.GetExtension(imageFile.FileName).ToLowerInvariant();

            if (!allowedExtensions.Contains(fileExtension))
                throw new Exception("Sadece JPG ve PNG formatında resim yükleyebilirsiniz.");

            // Dosya boyutunu kontrol et (5MB)
            if (imageFile.Length > 5 * 1024 * 1024)
                throw new Exception("Dosya boyutu 5MB'dan büyük olamaz.");

            // Film resimleri için klasör
            var uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Upload", "Movies");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            // Benzersiz dosya adı oluştur
            var uniqueFileName = $"{Guid.NewGuid()}_{DateTime.Now.Ticks}{fileExtension}";
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            // Dosyayı kaydet
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }

            return "/Upload/Movies/" + uniqueFileName;
        }

        // Film resmini silme yardımcı metodu
        public static void DeleteMovieImage(string imageUrl, IWebHostEnvironment webHostEnvironment)
        {
            if (string.IsNullOrEmpty(imageUrl))
                return;

            var imagePath = Path.Combine(webHostEnvironment.WebRootPath, imageUrl.TrimStart('/'));
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
        }
    }
}