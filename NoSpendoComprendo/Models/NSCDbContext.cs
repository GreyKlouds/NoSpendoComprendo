using Microsoft.EntityFrameworkCore;

namespace NoSpendoComprendo.Models
{
    public class NSCDbContext : DbContext
    {
       public  DbSet<Expense> Expenses { get; set; }

        public NSCDbContext(DbContextOptions<NSCDbContext> options): base(options)
        {
              
        }
    }
}
