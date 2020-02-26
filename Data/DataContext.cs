using Microsoft.EntityFrameworkCore;
using RegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
            base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarIn> CarIns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(e => e.HasIndex(property => new { property.PlateNo }).IsUnique());
            modelBuilder.Entity("RegistrationApp.Models.CarIn", b =>
            {
                b.HasOne("RegistrationApp.Models.Car", "Car")
                    .WithMany()
                    .HasForeignKey("CarId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("RegistrationApp.Models.Employee", "ExternalEmployee")
                    .WithMany()
                    .HasForeignKey("ExternalEmployeeId")
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

                b.HasOne("RegistrationApp.Models.Employee", "InternalEmployee")
                    .WithMany()
                    .HasForeignKey("InternalEmployeeId")
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            });

        }

    }
}

