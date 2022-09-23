using System.ComponentModel.DataAnnotations;

namespace GameHub.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        // validation rules are written above the property
        [MinLength (2, ErrorMessage ="Hey! This is way too Short")]
        [MaxLength(100)]
        [Required]
        public string? Name { get; set; }

        [Range(0.01, 999999)]
        public decimal? Price { get; set; }
        
    }
}
