using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace MagsAzureApp.Models
{

    public class IndexViewModel
    {
        public bool HasPassword { get; set; }

        public bool HasBirthDate { get; set; }

        public bool HasFirstName { get; set; }

        public bool HasLastName { get; set; }

        public string BirthDate { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class SetBirthDateViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Date)]
        [Display(Name = "New birth date")]
        public string NewBirthDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Confirm new birth date")]
        [Compare("NewBirthDate", ErrorMessage = "The new birth date and confirmation birth date do not match.")]
        public string ConfirmBirthDate { get; set; }
    }

    public class SetFirstNameViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "New first name")]
        public string NewFirstname { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Confirm new Firstname")]
        [Compare("NewFirstname", ErrorMessage = "The new Firstname and confirmation Firstname do not match.")]
        public string ConfirmLastname { get; set; }
    }

    public class SetLastNameViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "New lastname")]
        public string NewLastname { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Confirm new Lastname")]
        [Compare("NewLastname", ErrorMessage = "The new Lastname and confirmation Lastname do not match.")]
        public string ConfirmLastname { get; set; }
    }


    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangeBirthDateViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Current birth date")]
        public string OldBirthDate{ get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Date)]
        [Display(Name = "New BirthDate")]
        public string NewBirthDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Confirm new BirthDate")]
        [Compare("NewBirthDate", ErrorMessage = "The new BirthDate and confirmation BirthDate do not match.")]
        public string ConfirmBirthDate { get; set; }
    }

    public class ChangeFirstNameViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Current first name")]
        public string OldFirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Display(Name = "New first name")]
        public string NewFirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Confirm new first name")]
        [Compare("NewFirstName", ErrorMessage = "The new firstname and confirmation firstname do not match.")]
        public string ConfirmFirstName { get; set; }
    }

    public class ChangeLastNameViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Current last name")]
        public string OldLastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Display(Name = "New last name")]
        public string NewLastName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Confirm new last name")]
        [Compare("NewLastName", ErrorMessage = "The new lastname and confirmation lastname do not match.")]
        public string ConfirmLastName { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}