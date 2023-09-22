using System.ComponentModel.DataAnnotations;

namespace WEBORIS.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Cost { get; set; }
        public double? NewCost { get; set; }
        public string? Sku { get; set; }
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
    }
}
