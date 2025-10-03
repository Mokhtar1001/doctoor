using EHospital.Models;
using Microsoft.EntityFrameworkCore;

namespace EHospital.DataAccess
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Patient> patients {  get; set; } 
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlServer("Data Source=.;initial catalog= hospitalDB519;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
            


        }
    }
}
