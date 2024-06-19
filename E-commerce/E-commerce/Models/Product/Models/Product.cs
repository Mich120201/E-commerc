using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ecommerce.Models.Option.Models;
using ecommerce.Models.Order.Models;
using Newtonsoft.Json;

namespace ecommerce.Models.Product.Models
{
    public class Product
    {
        // keys/
        [Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Key] public Guid ProductId { get; set; }
        public ICollection<ProductOption>? ProductOption { get; set; }

        public ICollection<ThumbImage>? ThumbImages { get; set; }
        public ICollection<OrderDetail>? OrderDetail { get; set; }

        // /keys

        [Required][MaxLength(100)] public string ProductName { get; set; }
        [MaxLength(5000)] public string? ProductDescription { get; set; }
        [Required] public float ProductTotalPrice { get; set; }
        [Required] public float ProductWeight { get; set; }
        [Required] public float ProductSizeX { get; set; }
        [Required] public float ProductSizeY { get; set; }
        [Required] public float ProductSizeZ { get; set; }
        [Required] public uint ProductStock { get; set; }
        public bool SoftDelete {  get; set; }
    }
}
