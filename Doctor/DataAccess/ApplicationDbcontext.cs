using Doctor.Models;
using Microsoft.EntityFrameworkCore;

namespace Doctor.DataAccess
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public DbSet<Patient> patients { get; set; }
        public DbSet<doctor> doctors { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlServer("Data Source=.;initial catalog= Doctor;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);



        }
    }
}