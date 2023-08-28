using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BLOODBANK2.Models
{
    // Recipient.cs
    public class Recipient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string? Name { get; set; }
  
        public string? ContactNumber { get; set; }
        public string? State { get; set; }
        public string? District { get; set; }
        public string? Country { get; set; }
    }

}
