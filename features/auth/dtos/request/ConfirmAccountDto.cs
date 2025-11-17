using System.ComponentModel.DataAnnotations;

namespace SOA.features.auth.dtos.request
{
    public class ConfirmAccountDto
    {
        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El token es obligatorio.")]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "El token debe tener exactamente 6 dígitos.")]
        public string Token { get; set; }
    }
}
