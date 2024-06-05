using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models.Option.Models
{
    public class Option
    {
        // keys/

        [Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Key] public int OptionId { get; set; }
        public ICollection<ProductOption> ProductOptions { get; set; }

        public int OptionGroupId { get; set; }
        public OptionGroup OptionGroup { get; set; }

        // /keys

        [Required][MaxLength(50)] public string OptionName { get; set; }
    }
}
