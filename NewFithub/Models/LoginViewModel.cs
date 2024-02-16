using System.ComponentModel.DataAnnotations;

namespace NewFithub.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email tidak boleh kosong.")]
        [EmailAddress(ErrorMessage = "Format email tidak valid.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password tidak boleh kosong.")]
        public string? Password { get; set; }
    }

}
