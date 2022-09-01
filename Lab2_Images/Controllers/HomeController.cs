using Lab2_Images.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Lab2_Images.Context;
using Lab2_Images.Services;
using Microsoft.EntityFrameworkCore;

namespace Lab2_Images.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IComputerVisionService _computerVisionService;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment, AppDbContext context)
        {
            _logger = logger;
            _computerVisionService = new ComputerVisionService();
            _hostEnvironment = hostEnvironment;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allImages = await _context.Images.ToListAsync() ;
            return View(allImages);
        }

        public async Task<IActionResult> Details(int id)
        
        {
            var image = await _context.Images.FirstOrDefaultAsync(x => x.Id == id);
            var analysedImage = await _computerVisionService.AnalyzeImageUrl(image.ImageUrl);

            await _computerVisionService.GetThumbnail(image.ImageUrl);
            return View(analysedImage);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Images images)
        {
            if (!ModelState.IsValid)
            {
                return View(images);
            }

            await _context.Images.AddAsync(images);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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