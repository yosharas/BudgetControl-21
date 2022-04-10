using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Budget //: IBudgetController
    {
        public int foodBudget { get; } = 2000;
        public int billsBudget { get; } = 1500;
        public int pleasuresBudget { get; } = 1000;
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

        // Metoda wywoływana przez event - informacja o wykorzystaniu budżetu
        public void AboutBudgetUsage(StandardExpense expense) // do eventu
        {
            Console.WriteLine($"Budget - year: {BudgetYear}, month: {BudgetMonth}");

            switch (expense.Category)
            {
                case "Food":
                    if (FoodSum > foodBudget)
                    {
                        double overspend = (FoodSum - foodBudget) / foodBudget;
                        Console.WriteLine($"You have exceeded your planned food budget by {overspend.ToString("N2")}%");
                    }
                    else
                    {
                        double budgetUsage = (FoodSum / foodBudget) * 100;
                        Console.WriteLine($"You have spent {budgetUsage.ToString("N2")}% of your food budget");
                    }
                    break;
                case "Bills":
                    if (BillsSum > billsBudget)
                    {
                        double overspend = (BillsSum - billsBudget) / billsBudget;
                        Console.WriteLine($"You have exceeded your planned food budget by {overspend.ToString("N2")}%");
                    }
                    else
                    {
                        double budgetUsage = (BillsSum / billsBudget) * 100;
                        Console.WriteLine($"You have spent {budgetUsage.ToString("N2")}% of your food budget");
                    }
                    break;
                case "Pleasures":
                    if (PleasuresSum > pleasuresBudget)
                    {
                        double overspend = (PleasuresSum - pleasuresBudget) / pleasuresBudget;
                        Console.WriteLine($"You have exceeded your planned food budget by {overspend.ToString("N2")}%");
                    }
                    else
                    {
                        double budgetUsage = (PleasuresSum / pleasuresBudget) * 100;
                        Console.WriteLine($"You have spent {budgetUsage.ToString("N2")}% of your food budget");
                    }
                    break;
            }
        }
        public void AboutBudgetUsage()
        {
            Console.WriteLine($"Budget - year: {BudgetYear}, month: {BudgetMonth}");
            if (FoodSum > foodBudget)
            {
                double overspend = (FoodSum - foodBudget) / foodBudget;
                Console.WriteLine($"You have exceeded your planned food budget by {overspend.ToString("N2")}%");
            }
            else
            {
                double budgetUsage = (FoodSum / foodBudget) * 100;
                Console.WriteLine($"You have spent {budgetUsage.ToString("N2")}% of your food budget");
            }
            if (BillsSum > billsBudget)
            {
                double overspend = (BillsSum - billsBudget) / billsBudget;
                Console.WriteLine($"You have exceeded your planned food budget by {overspend.ToString("N2")}%");
            }
            else
            {
                double budgetUsage = (BillsSum / billsBudget) * 100;
                Console.WriteLine($"You have spent {budgetUsage.ToString("N2")}% of your food budget");
            }
            if (PleasuresSum > pleasuresBudget)
            {
                double overspend = (PleasuresSum - pleasuresBudget) / pleasuresBudget;
                Console.WriteLine($"You have exceeded your planned food budget by {overspend.ToString("N2")}%");
            }
            else
            {
                double budgetUsage = (PleasuresSum / pleasuresBudget) * 100;
                Console.WriteLine($"You have spent {budgetUsage.ToString("N2")}% of your food budget");
            }
        }
    }
}