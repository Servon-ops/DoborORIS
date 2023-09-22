using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WEBORIS.Interfaces;
using WEBORIS.Models;
using WEBORIS.ViewModels;

namespace WEBORIS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsRepository _newsRepository;

        public HomeController(ILogger<HomeController> logger, INewsRepository newsRepository)
        {
            _logger = logger;
            _newsRepository = newsRepository;
        }
        public async Task<IActionResult> Index()
        {
            var news = await _newsRepository.GetAllNews();
            List<NewsViewModel> result = new List<NewsViewModel>();
            foreach (var e in news)
            {
                var newsViewModel = new NewsViewModel()
                {
                    Id = e.Id,
                    Category = e.Category,
                    Title = e.Title,
                    Author = e.Author,
                    DateTime = e.DateTime,
                    ViewsCount = e.ViewsCount,
                    Description = e.Description,
                    ImagePath = e.ImagePath,
                };
                result.Add(newsViewModel);
            }
            return View(result);
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