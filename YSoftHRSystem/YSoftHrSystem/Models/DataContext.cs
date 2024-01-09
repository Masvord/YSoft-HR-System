using Microsoft.EntityFrameworkCore;



namespace YSoftHrSystem.Models
{
    public class ReCapProjectDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=YSoftDB;Trusted_Connection=true");
        }



        public DbSet<User> Users { get; set; }


    }
}