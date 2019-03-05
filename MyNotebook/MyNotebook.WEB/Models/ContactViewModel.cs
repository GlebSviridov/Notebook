using System.ComponentModel.DataAnnotations;

namespace MyNotebook.WEB.Models
{
    public class ContactViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [Display(Name = "Description")]
        public string ShortDescription { get; set; }

        public bool IsDeleted { get; set; }
    }
}