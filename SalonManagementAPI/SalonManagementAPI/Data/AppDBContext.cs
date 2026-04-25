using Microsoft.EntityFrameworkCore;
using SalonManagementAPI.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalonManagementAPI.Data
{
    public class AppDBContext : DbContext

    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
