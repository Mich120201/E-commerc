using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models.CardDetailsInputModel
{
    public class CardDetailsInputModel()
    {
        [Required(ErrorMessage = "nome richiesto")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "cognome richiesto")]
        public string Surname { get; set; }

        [Required]
        public long Amount {  get; set; }

        [Required(ErrorMessage = "numero carta rechiesto")]
        [MinLength(18, ErrorMessage = "numero carta invalido")]
        [MaxLength(19, ErrorMessage = "numero carta invalido")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "codice di sicurezza richiesto")]
        [MinLength(3, ErrorMessage = "numero Cvv invalido")]
        [MaxLength(4, ErrorMessage = "numero Cvv invalido")]
        public string Cvv { get; set; }

        [Required(ErrorMessage = "data di scadenza richiesta")]
        [MaxLength(5, ErrorMessage = "data di scadenza invalida")]
        [MinLength(5, ErrorMessage = "data di scadenza invalida")]
        public string ExpiryDate { get; set; }
    }
}
