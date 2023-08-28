using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BLOODBANK2.Models
{
    // Donor.cs
    public class Donor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Number { get; set; }
        public string? Email { get; set; } 
        public DateTime Dob { get; set; }
        public string? Blood { get; set; } 
        public string? Gender { get; set; } 
        public string? State { get; set; } 
        public string? City { get; set; } 
        public string? Alcoholic { get; set; } 
        public string? Password { get; set; }
        // You can add other properties as needed

        // Flags for Blood Donation Request and Report
        public bool BloodDonationRequested { get; set; }
       
        public string? ReportReason { get; set; }
    }

}
