using BudgetApp.Enums;

namespace BudgetApp.MVVM.Model
{
    public class Income
    {
        public int IncomeId { get; set; } //PK
        public string Name { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public RepeatsEnum Repeats { get; set; }
    }
}
