﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HellwegFinal.Models;

#nullable disable

namespace HellwegFinal.Data
{
    public partial class DriverdatabaseContext : DbContext
    {
        public DriverdatabaseContext()
        {
        }

        public DriverdatabaseContext(DbContextOptions<DriverdatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<DriverCar> DriverCars { get; set; }
        public virtual DbSet<EmpRole> EmpRoles { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Infraction> Infractions { get; set; }
        public virtual DbSet<InfractionType> InfractionTypes { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.HasKey(e => e.DriverIndex)
                    .HasName("PK__Drivers__CB6467CDD2796FB1");

                entity.Property(e => e.DriverIndex).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SSN");
            });

            modelBuilder.Entity<DriverCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DriverCars");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.VehiclePlate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpRole>(entity =>
            {
                entity.HasKey(e => e.EmpRoleIndex)
                    .HasName("PK__EmpRoles__C278BDD3A7D1EB89");

                entity.Property(e => e.EmpRoleIndex).ValueGeneratedNever();

                entity.Property(e => e.EmpRoleDescription)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EmpRoleTitle)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeIndex)
                    .HasName("PK__Employee__7DC60B3A75F5DFA6");

                entity.Property(e => e.EmployeeIndex).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.EmproleIndex).HasColumnName("EMPRoleIndex");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmproleIndexNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmproleIndex)
                    .HasConstraintName("FK__Employees__EMPRo__2C3393D0");
            });

            modelBuilder.Entity<Infraction>(entity =>
            {
                entity.HasKey(e => e.InfractionIndex)
                    .HasName("PK__Infracti__03420ABC5241CC8F");

                entity.Property(e => e.InfractionIndex).ValueGeneratedNever();

                entity.Property(e => e.InfractionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmployeeIndexNavigation)
                    .WithMany(p => p.Infractions)
                    .HasForeignKey(d => d.EmployeeIndex)
                    .HasConstraintName("FK__Infractio__Emplo__35BCFE0A");

                entity.HasOne(d => d.InfractionTypeIndexNavigation)
                    .WithMany(p => p.Infractions)
                    .HasForeignKey(d => d.InfractionTypeIndex)
                    .HasConstraintName("FK__Infractio__Infra__37A5467C");

                entity.HasOne(d => d.VehicleIndexNavigation)
                    .WithMany(p => p.Infractions)
                    .HasForeignKey(d => d.VehicleIndex)
                    .HasConstraintName("FK__Infractio__Vehic__36B12243");
            });

            modelBuilder.Entity<InfractionType>(entity =>
            {
                entity.HasKey(e => e.InfractionTypeIndex)
                    .HasName("PK__Infracti__D5BBFEBF20A3762B");

                entity.ToTable("InfractionType");

                entity.Property(e => e.InfractionTypeIndex).ValueGeneratedNever();

                entity.Property(e => e.InfractionTypeDescription)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.InfractionTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.VehicleIndex)
                    .HasName("PK__Vehicle__1E2177D077EE6184");

                entity.ToTable("Vehicle");

                entity.Property(e => e.VehicleIndex).ValueGeneratedNever();

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleAge)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VehiclePlate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.VehicleOwnerNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VehicleOwner)
                    .HasConstraintName("FK__Vehicle__Vehicle__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}