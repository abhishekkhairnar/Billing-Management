using System.ComponentModel.DataAnnotations;

namespace Billing_Management_System.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Email is mandatory")]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$",ErrorMessage ="Invalid Email address")]
        [Key]
        public String Email { get; set; }

		[Required(ErrorMessage = "Full Name is Required")]
		public String FullName { get; set; }

        [StringLength(maximumLength:15,MinimumLength =6)]
		[Required(ErrorMessage = "Password is Required")]
		public String Password { get; set; }

        public String Role { get; set; }

        //[Required(ErrorMessage ="Please Select the department")]
        public String Department { get; set; }
        public String ReportingTo { get; set; }
    }
}
