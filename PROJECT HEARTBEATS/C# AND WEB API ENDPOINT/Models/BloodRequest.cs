using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLOODBANK2.Models
{
    public class BloodRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
      
        public string? request { get; set; }

        public string? recipient_name { get; set; }

        public int DonorId { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
