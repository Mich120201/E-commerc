using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models.Order.Models
{
    using ecommerce.Models.User.Models;
    public class Order
    {
        // keys/

        [Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Key] public int OrderId { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        // /keys

        [Required] public float OrderAmount { get; set; }
        [Required][MaxLength(100)] public string OrderShipName { get; set; }
        [Required][MaxLength(100)] public string OrderShipAddress { get; set; }
        [Required][MaxLength(100)] public string OrderShipAddress2 { get; set; }
        [Required][MaxLength(50)] public string OrderCity { get; set; }
        [Required][MaxLength(50)] public string OrderState { get; set; }
        [Required][MaxLength(20)] public string OrderZip { get; set; }
        [Required][MaxLength(50)] public string OrderCountry { get; set; }
        [MaxLength(20)] public string OrderPhone { get; set; }
        [MaxLength(20)] public string OrderFax { get; set; }
        [Required] public float OrderShipping { get; set; }
        [Required] public float OrderTax { get; set; }
        [Required][MaxLength(100)][EmailAddress] public string OrderEmail { get; set; }
        [Required] public DateTime OrderDate { get; set; }
        [Required] public byte OrderShipped { get; set; }
        [Required][MaxLength(80)] public string OrderTrackingNumber { get; set; }
    }
}
