using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models.Option.Models
{
    public class OptionGroup
    {
        // keys/

        [Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Key] public int OptionGroupId { get; set; }

        public ICollection<Option> Options { get; set; }

        // /keys

        [MaxLength(50)] public string OptionGroupName { get; set; }
    }
}
