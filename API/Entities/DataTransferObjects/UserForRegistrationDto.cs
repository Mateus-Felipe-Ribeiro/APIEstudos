using System.ComponentModel.DataAnnotations;

namespace API.Entities.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Email é requerido.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Senha é requerido.")]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage = "As senhas não coincidem.")]
        public string? ConfirmPassword { get; set; }
        public string? ClientURI { get; set; }
    }
}
