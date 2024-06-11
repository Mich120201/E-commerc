using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models.Option.Models
{
    public class Option
    {
        // keys/

        [Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Key] public Guid OptionId { get; set; }
        public ICollection<ProductOption> ProductOptions { get; set; }

        public Guid OptionGroupId { get; set; }
        public OptionGroup OptionGroup { get; set; }

        // /keys

        [Required][MaxLength(50)] public string OptionName { get; set; }
    }
}
