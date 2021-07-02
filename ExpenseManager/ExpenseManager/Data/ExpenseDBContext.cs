namespace ExpenseManager.Models
{
    using Microsoft.EntityFrameworkCore;

    public class ExpenseDBContext : DbContext
    {
        public virtual DbSet<ExpenseReport> ExpenseReport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=localhost;Database=ExpenseReport;Trusted_Connection=True;");
            }
        }
    }
}
