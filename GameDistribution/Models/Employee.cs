using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GameDistribution.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Employee First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Employee Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(9, MinimumLength = 9)]
        public string EmployeeNumber { get; set; }

        public IEnumerable<Customer> customers { get; set; }
    }
}
