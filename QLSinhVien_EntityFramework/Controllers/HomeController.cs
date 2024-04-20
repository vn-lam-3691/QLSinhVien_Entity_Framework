using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLSinhVien_DatabaseFirst.Models;
using QLSinhVien_EntityFramework.Models;
using System.Diagnostics;

namespace QLSinhVien_EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private QlsinhVienEfAspContext _db;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _db = new QlsinhVienEfAspContext();
        }

        public IActionResult Index()
        {
            var list = _db.SinhViens.Include(x => x.MaLopNavigation).ThenInclude(x => x.MaKhoaNavigation)
                .Where(x => x.MaLopNavigation.MaKhoa == 1).ToList();
            return View(list);
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
