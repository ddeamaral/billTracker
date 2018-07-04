using Microsoft.EntityFrameworkCore;

namespace marriednowwhat.Models.Db
{
    public class BillContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite ("Data Source=bills.db");
        }
    }
}