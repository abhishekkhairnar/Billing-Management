using System.ComponentModel.DataAnnotations;

namespace Billing_Management_System.Models
{
    public class VendorModel
    {
        [Key]
        public String Email { get; set; }
        public String VendorCompanyName { get; set; }
        public String Address { get; set; }
        public String GST { get; set; }
        public String CIN { get; set; }
        public String CompanyPersonName { get; set; }
        public String CompanyPersonContact { get; set; }
    }
}
