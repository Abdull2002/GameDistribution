using System.ComponentModel.DataAnnotations;

namespace GameDistribution.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string city { get; set; }
        [Required]
        [StringLength(50)]
        public string country { get; set; }        
        [Required]
        [StringLength(50)]
        public string state { get; set; }



    }
}
