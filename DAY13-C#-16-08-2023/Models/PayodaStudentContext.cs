﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JwtAuth.Models;

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

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

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
