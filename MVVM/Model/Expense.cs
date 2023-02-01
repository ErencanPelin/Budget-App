using BudgetApp.Enums;
using System;

namespace BudgetApp.MVVM.Model
{
    public class Expense
    {
        public string ExpenseId { get; set; } //PK
        public string Name { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public RepeatsEnum Repeats { get; set; }

        public Expense(string name, string description, double amount, RepeatsEnum repeats)
        {
            ExpenseId = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            Amount = amount;
            Repeats = repeats;
        }
    }
}
