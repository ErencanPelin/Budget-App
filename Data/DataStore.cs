using BudgetApp.MVVM.Model;
using System.Collections.Generic;

namespace BudgetApp.Data
{
    public static class DataStore
    {
        public static List<Expense> expenses= new List<Expense>();
        public static List<Income> income = new List<Income>();
    
        public static void InitTestData()
        {
            expenses.Add(new Expense("myFirstExpense", "description", 10.0, Enums.RepeatsEnum.Yearly));
        }
    }
}
