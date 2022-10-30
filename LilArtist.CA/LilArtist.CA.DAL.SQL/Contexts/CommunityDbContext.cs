using LilArtist.CA.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LilArtist.CA.DAL.SQL
{
    public class CADbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=TestApiDB;User Id=app;Password=password;Include Error Detail=true;Maximum Pool Size=10");
            optionsBuilder.UseNpgsql("Host=postgres;Port=5432;Pooling=true;Database=CAApiDB;User Id=app;Password=password;Include Error Detail=true;Maximum Pool Size=10");
            //optionsBuilder.UseSqlServer("server=localhost, 1433;database=TestApiDB;User Id=sa;password=jfwQPWjd3dd;trusted_connection=False");
            //optionsBuilder.UseSqlServer("server=DESKTOP-KQKU8P9\\SQLEXPRESS;database=TestApiDB;trusted_connection=True");
        }

        public DbSet<Lot> lots { get; set; }
    }
}