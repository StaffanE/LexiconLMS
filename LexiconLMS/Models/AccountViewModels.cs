using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LexiconLMS.Models
{
            
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [DisplayFormat(NullDisplayText = "")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        [DisplayFormat(NullDisplayText = "")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [DisplayFormat(NullDisplayText = "")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [DisplayFormat(NullDisplayText = "")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Lösenord")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekräfta lösenord")]
        [Compare("Password", ErrorMessage = "Lösenordet och det bekräftade lösenordet matchar inte.")]
        public string ConfirmPassword { get; set; }

        //[Required]                                  // Tillagt!
        //[Display(Name = "User name")]
        //public string UserName { get; set; } 

        [Required]
        [Display(Name = "Förnamn")]
        [DisplayFormat(NullDisplayText = "")]
        public string FirstName { get; set; } 
 
        [Required]
        [Display(Name = "Efternamn")]
        [DisplayFormat(NullDisplayText = "")]
        public string LastName { get; set; }

        //[Required]
        //[Display(Name = "Fullt namn")]
        //public string FullName { get; set; }

        [Required]
        [Display(Name = "Mobil")]
        [DisplayFormat(NullDisplayText = "")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Grupp")]
        [DisplayFormat(NullDisplayText = "")]
        public int? GroupId { get; set; }

        [Display(Name = "Roll")]
        [DisplayFormat(NullDisplayText = "")]
        public string Title { get; set; }

        [Display(Name = "Grupp")]
        [DisplayFormat(NullDisplayText = "")]
        public virtual Group Group { get; set; }                // Navigation property
                     
    }


    

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
