using System.ComponentModel.DataAnnotations;

namespace LinaMovies.Web.ViewModels.Authentication
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}