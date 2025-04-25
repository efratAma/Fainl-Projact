using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FullStack.api;

public partial class dbClass : DbContext
{
    public dbClass()
    {
    }

    public dbClass(DbContextOptions<dbClass> options)
        : base(options)
    {
    }

    public virtual DbSet<Apartment> Apartments { get; set; }

    public virtual DbSet<Investor> Investors { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\פרויקט סיום\\Data\\dataBase.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Apartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Apartmen__3214EC070C62DEB7");

            entity.ToTable("Apartment");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Invester).WithMany(p => p.Apartments)
                .HasForeignKey(d => d.InvesterId)
                .HasConstraintName("FK_Apartment_ToTable");

            entity.HasOne(d => d.ProjectNumberNavigation).WithMany(p => p.Apartments)
                .HasForeignKey(d => d.ProjectNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Apartment_ToTable_1");
        });

        modelBuilder.Entity<Investor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Investor__3214EC07B49F5B5C");

            entity.ToTable("Investor");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastName)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Projects__3214EC07022465CE");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProjactName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
