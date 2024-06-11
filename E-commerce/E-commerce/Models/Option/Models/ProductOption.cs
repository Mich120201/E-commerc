using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models.Option.Models
{
    using ecommerce.Models.Product.Models;
    public class ProductOption
    {

        // keys/

        [Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Key] public Guid ProductOptionId { get; set; }
        public Guid OptionId { get; set; }
        public Option Option { get; set; }
        public ICollection<Product> Product { get; set; }
        public Guid OptionGroupId { get; set; }

        // /keys

        [Required] public double OptionPriceIncrement { get; set; }
    }
}
