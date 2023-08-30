using System.ComponentModel.DataAnnotations;

namespace mvcApplication1.Models
{
    public class KYC
    {
        [Key]
        [Required]
        public int empId { get; set; }
        [Required]
        public string empName { get; set; }
        [Required]
        public int empPhone { get; set; }
        [Required]
        public string empRole { get; set; }
        [Required]
        public string empCity { get; set; }
    }
}

