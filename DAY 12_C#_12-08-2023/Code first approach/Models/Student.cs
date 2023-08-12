using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDetailsCF.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rollno { get; set; }

        [Required]
        public string? Stuname { get; set; }
        
        [Required]
        public string? Addr { get; set; }

        [Required]
        public long Phno { get; set; }

    }
}
