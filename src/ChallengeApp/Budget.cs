using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Budget : IBudgetController, IComparable<Budget>
    {
        public int FoodBudget { get; } = 2000;
        public int BillsBudget { get; } = 1500;
        public int PleasuresBudget { get; } = 1000;
        public int Year { get; }
        public int Month { get; }
        public List<Expense> FoodExpensesInBudget { get; } = new List<Expense>();
        public List<Expense> BillsExpensesInBudget { get; } = new List<Expense>();
        public List<Expense> PleasuresExpensesInBudget { get; } = new List<Expense>();
        public double FoodSum { get; private set; }
        public double BillsSum { get; private set; }
        public double PleasuresSum { get; private set; }
        public bool FoodBudgetIsExceeded { get; private set; } = false;
        public bool BillsBudgetIsExceeded { get; private set; } = false;
        public bool PleasuresBudgetIsExceeded { get; private set; } = false;
        public bool FoodBudgetWasExceededWithLastExpense { get; private set; } = false;
        public bool BillsBudgetWasExceededWithLastExpense { get; private set; } = false;
        public bool PleasuresBudgetWasExceededWithLastExpense { get; private set; } = false;

        public Budget(int month, int year)
        {
            this.Month = month;
            this.Year = year;
        }

        public int CompareTo(Budget that)
        {

            if (that == null)
            {
                return 1;
            }

            int result = this.Year.CompareTo(that.Year);
            if (result == 0)
            {
                return this.Month.CompareTo(that.Month);
            }
            return result;
        }
        public void AddExpenseToBudget(Expense expense)
        {
            switch (expense.Category)
            {
                case "food":
                    FoodExpensesInBudget.Add(expense);
                    FoodSum += expense.Value;
                    break;

                case "bills":
                    BillsExpensesInBudget.Add(expense);
                    BillsSum += expense.Value;
                    break;

                case "pleasures":
                    PleasuresExpensesInBudget.Add(expense);
                    PleasuresSum += expense.Value;
                    break;
            }
        }
        public void IsBudgetExceeded(Expense expense)
        {
            switch (expense.Category)
            {
                case "food":
                    if (FoodSum > FoodBudget && FoodBudgetIsExceeded == false)
                    {
                        FoodBudgetIsExceeded = true;
                        FoodBudgetWasExceededWithLastExpense = true;
                        if (BudgetIsNowExceeded != null)
                        {
                            BudgetIsNowExceeded(this, new EventArgs());
                        }
                        FoodBudgetWasExceededWithLastExpense = false;
                    }
                    break;
                case "bills":
                    if (BillsSum > BillsBudget && BillsBudgetIsExceeded == false)
                    {
                        BillsBudgetIsExceeded = true;
                        BillsBudgetWasExceededWithLastExpense = true;
                        if (BudgetIsNowExceeded != null)
                        {
                            BudgetIsNowExceeded(this, new EventArgs());
                        }
                        BillsBudgetWasExceededWithLastExpense = false;
                    }
                    break;
                case "pleasures":
                    if (PleasuresSum > PleasuresBudget && PleasuresBudgetIsExceeded == false)
                    {
                        PleasuresBudgetIsExceeded = true;
                        PleasuresBudgetWasExceededWithLastExpense = true;
                        if (BudgetIsNowExceeded != null)
                        {
                            BudgetIsNowExceeded(this, new EventArgs());
                        }
                        PleasuresBudgetWasExceededWithLastExpense = false;
                    }
                    break;
            }
        }
        public event BudgetExceededDelegate BudgetIsNowExceeded;
        public void AlertBudgetGotExceeded(object sender, EventArgs args)
        {
            if (FoodBudgetWasExceededWithLastExpense)
            {
                Console.WriteLine($"Budget {Year}-{Month} was exceded in food category by the amount of {FoodSum-FoodBudget:N2} PLN ({(FoodSum - FoodBudget)/FoodBudget*100:N2}%)");
            }
            if (BillsBudgetWasExceededWithLastExpense)
            {
                Console.WriteLine($"Budget {Year}-{Month} was exceded in bills category by the amount of { BillsSum - BillsBudget:N2} PLN ({(BillsSum - BillsBudget) / BillsBudget * 100:N2}%)");
            }
            if (PleasuresBudgetWasExceededWithLastExpense)
            {
                Console.WriteLine($"Budget {Year}-{Month} was exceded in pleasures categoryby the amount of {PleasuresSum - PleasuresBudget:N2} PLN ({(PleasuresSum - PleasuresBudget) / PleasuresBudget * 100:N2}%)");
            }
        }
    }
}