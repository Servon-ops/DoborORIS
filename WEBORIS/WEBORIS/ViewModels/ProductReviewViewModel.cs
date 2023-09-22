using System.Text.RegularExpressions;
using System;
using WEBORIS.Models;
using System.ComponentModel.DataAnnotations;

namespace WEBORIS.ViewModels
{
    public class ProductReviewViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Cost { get; set; }
        public double? NewCost { get; set; }
        public string? Sku { get; set; }
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
        public List<ReviewModel> ReviewModel { get; set; }
    }
}
