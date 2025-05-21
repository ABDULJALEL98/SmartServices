using System.ComponentModel.DataAnnotations;

namespace SmartServices.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        [Required]
        public string? ServiceName { get; set; } = string.Empty;
        public string? ServiceDescription { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public String? ImageUrl { get; set; }
        public int? CategoryId { get; set; }        // Foreign Key
        public Category? Category { get; set; }


    }
}
