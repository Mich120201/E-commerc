using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models.Order.Models
{
    using ecommerce.Models.Product.Models;
    public class OrderDetail
    {
        // keys/

        [Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Key] public int DetailId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        // /keys

        [Required][MaxLength(250)] public string DetailName { get; set; }
        [Required] public float DetailPrice { get; set; }
        [Required] public uint DetailQuantity { get; set; }
    }
}
