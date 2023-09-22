using System.ComponentModel.DataAnnotations;

namespace WEBORIS.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }

    }
}
