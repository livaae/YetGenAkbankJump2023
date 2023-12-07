using System.ComponentModel.DataAnnotations;

namespace Week11.API.Models.ModelMetadataTypes
{
    public class BankAccountMetadata
    {
        [Required(ErrorMessage = "Please enter first name.")]
        [StringLength(100, ErrorMessage = "Enter maximum 100 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name.")]
        [StringLength(100, ErrorMessage = "Enter maximum 100 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter phone number.")]
        [StringLength(11, ErrorMessage = "Enter maximum 100 characters.")]
        public string PhoneNumber { get; set; }
    }
}
