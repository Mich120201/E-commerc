using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models.Product.Models
{
    public class ThumbImage
    {
        // keys/

        [Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Key] public int ThumbImagesId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        // /keys

        [Required][MaxLength(100)] public string ThumbImageLink { get; set; }
    }
}
