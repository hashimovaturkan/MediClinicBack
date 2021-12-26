using System.ComponentModel.DataAnnotations;

namespace MediClinic.Domain.Models.FormModels
{
    public class RegisterFormModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }


    }
}
