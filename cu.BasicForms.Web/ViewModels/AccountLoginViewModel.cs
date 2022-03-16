using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cu.BasicForms.Web.ViewModels
{
    public class AccountLoginViewModel
    {
        [DisplayName("GebruikersNaam:")]
        [EmailAddress]
        [MaxLength(100)]
        [Required]
        public string Username { get; set; }
        [DisplayName("Wachtwoord:")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [DisplayName("Houd mij ingelogd:")]
        public bool RememberMe { get; set; }
    }
}
