using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationPractice.Models
{
    public class FormViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string GivenName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string FamilyName { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Display(Name = "Check this box")]
        public bool IsBlakeBetterThanBrian { get; set; }
        [Required]
        [Display(Name = "Amount of days without sleep")]
        public int DaysWithoutSleep { get; set; }
        [Required]
        public int FavoriteColorId { get; set; }
        [Display(Name = "Favorite color")]
        public string FavoriteColorName { get; set; }
        [Required]
        [Display(Name = "Favorite Movie")]
        public string BestMovie { get; set; }
        [Required(ErrorMessage = "Please enter a height")]
        [Display(Name = "Height (in)")]
        [Range(1, 120, ErrorMessage = "Height must be between 1 and 120")]
        public int? HeightInInches { get; set; }
        [Required(ErrorMessage = "Please enter an age")]
        [Display(Name = "Age")]
        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please enter a valid weight")]
        [Display(Name = "Weight")]
        [Range(0,500,ErrorMessage = "Weight Values must be between 0 and 500")]
        public double Weight { get; set; }
        [Required(ErrorMessage = "Please enter a valid phone")]
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }
    }
}
