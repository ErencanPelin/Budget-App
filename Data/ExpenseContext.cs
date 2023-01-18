using BudgetApp.MVVM.Model;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Data
{
    public class ExpenseContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=expenses.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
