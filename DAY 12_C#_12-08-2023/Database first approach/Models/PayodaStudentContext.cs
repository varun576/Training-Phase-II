using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentDetailsDBF.Models;

public partial class PayodaStudentContext : DbContext
{
    public PayodaStudentContext()
    {
    }

    public PayodaStudentContext(DbContextOptions<PayodaStudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Rollno);

            entity.Property(e => e.Rollno).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
