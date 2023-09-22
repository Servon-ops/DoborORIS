using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;
using WEBORIS.Data;
using WEBORIS.Interfaces;
using WEBORIS.Models;
using WEBORIS.Repository;
using WEBORIS.ViewModels;

namespace WEBORIS.Controllers
{
    public class ShopController : Controller
    {
        private readonly ILogger<ShopController> _logger;
        private readonly IProductRepository _productRepository;
        private readonly ApplicationDBContext _context;

        public ShopController(ILogger<ShopController> logger, IProductRepository productRepository, ApplicationDBContext context)
        {
            _logger = logger;
            _productRepository = productRepository;
            _context = context;
        }
        [Route("Shop")]
        public async Task<IActionResult> Shop()
        {
            var product = await _productRepository.GetAllProduct();
            List<ProductModel> result = new List<ProductModel>();
            foreach (var e in product)
            {
                var productModel = new ProductModel()
                {
                    Id = e.Id,
                    Category = e.Category,
                    Description = e.Description,
                    ShortDescription = e.ShortDescription,
                    Cost = e.Cost,
                    NewCost = e.NewCost,
                    Image = e.Image,
                    Name = e.Name,
                    Sku = e.Sku,

                };
                result.Add(productModel);
            }
            return View(result);
        }
        [Route("Shop/{sku}")]
        public IActionResult Product(string sku)
        {
            ProductModel productModel = _context.Products.FirstOrDefault(x => x.Sku == sku);
            ProductReviewViewModel productReviewViewModel = new ProductReviewViewModel()
            {
                Id = productModel.Id,
                Category = productModel.Category,
                Description = productModel.Description,
                ShortDescription = productModel.ShortDescription,
                Cost = productModel.Cost,
                NewCost = productModel.NewCost,
                Image = productModel.Image,
                Name = productModel.Name,
                Sku = productModel.Sku,
                ReviewModel = new List<ReviewModel>()
            };
            var review = _context.Reviews.Where(x => x.ProductId == productModel.Id).ToList();
            foreach (var e in review)
            {
                var reviewModel = new ReviewModel()
                {
                    Id = e.Id,
                    ProductId = e.ProductId,
                    Author = e.Author,
                    Description = e.Description,
                    Date = e.Date,
                };
                productReviewViewModel.ReviewModel.Add(reviewModel);
            }
            return View(productReviewViewModel);
        }

        [Route("Shop/Category/{category}")]
        public IActionResult Category(string category)
        {

            var product = _context.Products.ToList();
            List<ProductModel> result = product.Where(x => x.Category.Trim() == category.Trim()).ToList();
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
