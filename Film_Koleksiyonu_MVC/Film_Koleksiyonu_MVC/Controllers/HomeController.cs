using System.Diagnostics;
using Film_Koleksiyonu_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Film_Koleksiyonu_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // İstatistikleri hesapla
            ViewBag.MovieCount = await _context.Movies.CountAsync();
            ViewBag.FriendCount = await _context.Friends.CountAsync();
            ViewBag.SuggestionCount = await _context.MovieSuggestions.CountAsync();
            ViewBag.RatingCount = await _context.Movies.SumAsync(m => m.Rating);

            // Son eklenen filmleri getir
            ViewBag.RecentMovies = await _context.Movies
                .OrderByDescending(m => m.CreatedAt)
                .Take(8)
                .Select(m => new
                {
                    m.MovieId,
                    m.Title,
                    m.ImageUrl,
                    m.Category,
                    m.Rating
                })
                .ToListAsync();

            // Arkadaş önerilerini getir
            ViewBag.FriendSuggestions = await _context.MovieSuggestions
                .Where(s => s.Status == true)
                .OrderByDescending(s => s.CreatedAt)
                .Take(4)
                .Select(s => new
                {
                    s.MovieId,
                    FriendName = s.SuggestedByUser.Username,
                    FriendProfileImage = s.SuggestedByUser.ProfileImage,
                    MovieTitle = s.Movie.Title
                })
                .ToListAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
