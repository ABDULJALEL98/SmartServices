using System.ComponentModel.DataAnnotations;

namespace SmartServices.Dtos
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        [Required]
        public string? CategoryName { get; set; } = string.Empty;

    }
}
