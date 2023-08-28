using BLOODBANK2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BLOODBANK2.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Donor> Donors { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
    
        public DbSet<BloodRequest> BloodRequests{ get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
