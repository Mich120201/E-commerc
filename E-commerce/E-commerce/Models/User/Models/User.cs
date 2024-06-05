using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models.User.Models
{
    using ecommerce.Models.Order.Models;
    public class User
    {
        // keys/

        [Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Key] public int UserId { get; set; }
        public ICollection<Order> Orders { get; set; }

        // /keys

        [Required][MaxLength(500)] public string UserEmail { get; set; }
        [Required][MaxLength(500)] public string UserPassword { get; set; }
        [MaxLength(50)] public string? UserFirstName { get; set; }
        [MaxLength(50)] public string? UserLastName { get; set; }
        [MaxLength(90)] public string? UserCity { get; set; }
        [MaxLength(20)] public string? UserState { get; set; }
        [MaxLength(12)] public string? UserZip { get; set; }
        public byte UserEmailVerified { get; set; }
        [Required] public DateTime UserRegistrationDate { get; set; }
        [Required][MaxLength(20)] public string UserVerificationCode { get; set; }
        [MaxLength(50)] public string? UserIP { get; set; }
        [MaxLength(20)] public string? UserPhone { get; set; }
        [MaxLength(20)] string? UserFax { get; set; }
        [Required][MaxLength(20)] public string? UserCountry { get; set; }
        [Required][MaxLength(100)] public string? UserAddress1 { get; set; }
        [Required][MaxLength(50)] public string? UserAddress2 { get; set; }
    }
}
