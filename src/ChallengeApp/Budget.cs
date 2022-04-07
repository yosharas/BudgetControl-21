using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Budget //: IBudgetController
    {
        private int foodBudget = 2000;
        private int billsBudget = 1500;
        private int pleasuresBudget = 1000;
        public int BudgetYear { get; }
        public int BudgetMonth { get; }
        public List<StandardExpense> expensesInBudgetFood { get; } = new List<StandardExpense>();
        public List<StandardExpense> expensesInBudgetBills { get; } = new List<StandardExpense>();
        public List<StandardExpense> expensesInBudgetPleasures { get; } = new List<StandardExpense>();
        public double FoodSum { get; private set; }
        public double BillsSum { get; private set; }
        public double PleasuresSum { get; private set; }

        public Budget(int month, int year)
        {
            this.BudgetMonth = month;
            this.BudgetYear = year;
        }

        public void AboutBudgetUsage(StandardExpense expense) // do eventu
        {
            Console.WriteLine($"{BudgetYear} {BudgetMonth}");

            switch (expense.Category)
            {
                case "Food":
                    if (FoodSum > foodBudget)
                    {
                        double o = (FoodSum - foodBudget) / foodBudget;
                        Console.WriteLine($"You have exceeded your plannedc food budget by {o}");
                    }
                    else
                    {
                        double s = (FoodSum / foodBudget) * 100;
                        Console.WriteLine($"You have spent {s}% of your food budget");
                    }
                    break;
                case "Bills":
                    if (BillsSum > billsBudget)
                    {
                        double o = (BillsSum - billsBudget) / billsBudget;
                        Console.WriteLine($"You have exceeded your plannedc food budget by {o}");
                    }
                    else
                    {
                        double s = (BillsSum / billsBudget) * 100;
                        Console.WriteLine($"You have spent {s}% of your food budget");
                    }
                    break;
                case "Pleasures":
                    if (PleasuresSum > pleasuresBudget)
                    {
                        double o = (PleasuresSum - pleasuresBudget) / pleasuresBudget;
                        Console.WriteLine($"You have exceeded your plannedc food budget by {o}");
                    }
                    else
                    {
                        double s = (PleasuresSum / pleasuresBudget) * 100;
                        Console.WriteLine($"You have spent {s}% of your food budget");
                    }
                    break;
            }
        }

        public void AddExpenseToBudget(StandardExpense standardExpense)
        {
            switch (standardExpense.Category)
            {
                case "Food":
                    expensesInBudgetFood.Add(standardExpense);
                    FoodSum += standardExpense.Value;
                    break;

                case "Bills":
                    expensesInBudgetBills.Add(standardExpense);
                    BillsSum += standardExpense.Value;
                    break;

                case "Pleasures":
                    expensesInBudgetPleasures.Add(standardExpense);
                    PleasuresSum += standardExpense.Value;
                    break;
            }
        }
    }
}