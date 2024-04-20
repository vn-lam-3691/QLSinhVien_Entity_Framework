using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLSinhVien_CodeFirst.Data;
using QLSinhVien_CodeFirst.Models;
using System.Diagnostics;

namespace QLSinhVien_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppDatabaseContext _db;

        public HomeController(ILogger<HomeController> logger, AppDatabaseContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<SinhVien> listSV = _db.SinhViens
                .Include(x => x.Lop)
                .Include(x => x.Lop.Khoa)
                .Where(x => x.Lop.MaKhoa == 1)
                .ToList();
            return View(listSV);
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
