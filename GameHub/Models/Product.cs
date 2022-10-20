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

        public string? Photo { get; set; }

        //Foriegn key Field
        public int CategoryId { get; set; }
        // reference to parent model. Must need this to tell the child to get the category from the category model
        public Category? Category { get; set; }

        //reference to child model - 1 product can be in many cart Items
        public List<CartItem>? CartItems { get; set; }

        // Referencing to the 2nd child model Order details - 1 product can have multiple order detail records
        public List<OrderDetail>? OrderDetails { get; set; }

        public int ReleaseYear { get; set; }
        
    }
}
