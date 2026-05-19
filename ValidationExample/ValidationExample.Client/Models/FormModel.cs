using System.ComponentModel.DataAnnotations;

namespace ValidationExample.Client.Models;

public class FormModel
{
    [Required]
    [Display(Name = "First Name")]
    [MaxLength(10)]
    public string FirstName { get; set; } = "";
    [Required(ErrorMessage = "Please put a last name")]
    [Display(Name = "Last Name")]
    [MaxLength(50)]
    public string LastName { get; set; } = "";
    [Required]
    [Display(Name = "Email")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; } = "";
    [Required]
    [Display(Name = "Phone Number")]
    [Phone(ErrorMessage = "Please enter a valid phone number")]
    public string PhoneNumber { get; set; }
    
}