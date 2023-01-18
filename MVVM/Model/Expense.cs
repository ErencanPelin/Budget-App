using BudgetApp.Enums;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BudgetApp.MVVM.Model
{
    public class Expense
    {
        public int ExpenseId { get; set; } //PK
        public string Name { get; set; }
        public string Description { get; set; }
        public RepeatsEnum Repeats { get; set; }
        public virtual ICollection<Tag> Tags { get; set; } = new ObservableCollection<Tag>();
    }
}
