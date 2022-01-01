using Resources;
using System.ComponentModel.DataAnnotations;

namespace MediClinic.Domain.Models.FormModels
{
    public class ContactFormModel
    {
        [Display(ResourceType = typeof(ContactResource), Name = "Name")]
        [Required(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "CantBeEmpty")]
        public string Name { get; set; }

        [Display(ResourceType = typeof(ContactResource), Name = "Email")]
        [Required(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "CantBeEmpty")]
        [EmailAddress(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "İnvalidEmailAddress")]
        public string Email { get; set; }

        [Display(ResourceType = typeof(ContactResource), Name = "Comment")]
        [Required(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "CantBeEmpty")]
        public string Comment { get; set; }
    }
}
