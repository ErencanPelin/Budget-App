namespace BudgetApp.MVVM.Model
{
    public class Tag
    {
        public int TagId { get; set; } //PK
        public string Name { get; set; }
        public int ExpenseId { get; set; } //FK
        public virtual Expense Expense { get; set; }
    }
}
