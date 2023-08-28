namespace BLOODBANK2.Models
{
    public class Report
    {
        // Report.cs
        
            public int Id { get; set; }
            public int RecipientId { get; set; }
            public int DonorId { get; set; }
            public string? Reason { get; set; }
            public DateTime ReportDate { get; set; }
        }

    }

