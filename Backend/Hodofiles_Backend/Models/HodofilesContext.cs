using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Models;

public partial class HodofilesContext : DbContext
{
    public HodofilesContext()
    {

    }

    public HodofilesContext(DbContextOptions<HodofilesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Destination> Destinations { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DestinationId).HasColumnName("destination_id");
            entity.Property(e => e.Fare)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("fare");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Bookings_Customer");

            entity.HasOne(d => d.Destination).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.DestinationId)
                .HasConstraintName("FK_Bookings_Destinations");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(150)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .HasColumnName("lastName");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS")
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(200)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<Destination>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
