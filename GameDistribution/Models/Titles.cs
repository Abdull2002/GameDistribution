using System.ComponentModel.DataAnnotations;

namespace GameDistribution.Models
{
    public class Titles
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Year { get; set; }
        
    }
}
