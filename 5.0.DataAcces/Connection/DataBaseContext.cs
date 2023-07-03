using _0._0.DataTransfer.DtoAdditional;
using _5._0.DataAcces.Entity;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace _5._0.DataAcces.Connection
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext()
        {
            InitAutoMapper.Start();
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DtoAppSettings.connectionStringSqlServer);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().ToTable("Student");
            base.OnModelCreating(modelBuilder);
        }
    }
}
