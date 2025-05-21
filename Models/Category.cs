using System.ComponentModel.DataAnnotations;

namespace SmartServices.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        [Required]
        public string? CategoryName { get; set; } = string.Empty;
        public List<Service> Services { get; set; } = new List<Service>();
    }
}
