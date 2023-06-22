using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GameDistribution.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public bool Membership { get; set; }

        public IEnumerable<Titles> Titles { get; set; }

    }
}
