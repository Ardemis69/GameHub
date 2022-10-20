using System.ComponentModel.DataAnnotations;

namespace GameHub.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId
        {
            get; set;
        }
        //Referencing the parent 
        public Order? Order { get; set; }
        //Referencing the parent
        public Product? Product { get; set; }
    }
}
