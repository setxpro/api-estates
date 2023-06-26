using System.ComponentModel.DataAnnotations;

namespace Zend.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Nome deve conter no mínimo 2 caracteres.")]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
