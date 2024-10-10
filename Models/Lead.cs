using System.ComponentModel.DataAnnotations;

namespace LandingPageBackend.Models
{
    public class Lead
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }

        [Required]
        [MaxLength(400)]
        public string Mensagem { get; set; }
    }
}