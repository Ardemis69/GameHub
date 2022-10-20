using System.ComponentModel.DataAnnotations;

namespace GameHub.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string? CustomerId { get; set; }

        [Required]
        public int ProductId { get; set; }

        //Parent reference to Products - every cartItem is only for one product
        public Product? Product { get; set; }
    }
}
