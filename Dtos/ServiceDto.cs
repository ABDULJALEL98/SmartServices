using System.ComponentModel.DataAnnotations;

namespace SmartServices.Dtos
{
    public record ServiceDto
    {


        public int ServiceId { get; set; }
        [Required(ErrorMessage = "Service Name is required")]
        public string? ServiceName { get; set; } = string.Empty;
        public string? ServiceDescription { get; set; } = string.Empty;
        [Required(ErrorMessage = "Service Price is required")]
        public decimal Price { get; set; }
        public String? ImageUrl { get; set; }
        public int? CategoryId { get; set; }
    }
}
