using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models.Option.Models
{
    using ecommerce.Models.Product.Models;
    public class ProductOption
    {

        // keys/

        [Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Key] public int ProductOptionId { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public ICollection<Product> Product { get; set; }
        public uint OptionGroupId { get; set; }

        // /keys

        [Required] public double OptionPriceIncrement { get; set; }
    }
}
