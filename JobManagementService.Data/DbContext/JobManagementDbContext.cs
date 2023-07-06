using System;
using System.Collections.Generic;
using JobManagementService.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace JobManagementService.Data.DbContext;

public partial class JobManagementDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public JobManagementDbContext()
    {
    }

    public JobManagementDbContext(DbContextOptions<JobManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbJob> Jobs { get; set; }

    public virtual DbSet<TbJobType> JobTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Job");

            entity.ToTable("tb_Job", "JobManagement");

            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.Job).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("date");
            entity.Property(e => e.StartDate).HasColumnType("date");
        });

        modelBuilder.Entity<TbJobType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_JobType");

            entity.ToTable("tb_JobType", "JobManagement");

            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.ModifiedDate).HasColumnType("date");
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
