using System.ComponentModel.DataAnnotations;

namespace Billing_Management_System.Models
{
    public class UserModel
    {
        [Key]
        public String Email { get; set; }
        [Required(ErrorMessage ="Email is Required")]
        public String FullName { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public String Password { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public String Role { get; set; }
        public String Department { get; set; }
        public String ReportingTo { get; set; }
    }
}
