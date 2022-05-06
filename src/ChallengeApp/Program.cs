using System;
using System.Collections.Generic;
using System.IO;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ListofExpenses listofExpenses = new ListofExpenses();
            List<Budget> listOfBudgets = new List<Budget>();
            listofExpenses.AddListofExpenses(ReadExpensesFromFile());
            FillingBudgets(listofExpenses, listOfBudgets);
            listofExpenses.AddExpenseToListInFileAndMemory();
            Console.WriteLine($"\nNumber of items on the list of expenses: {listofExpenses.expensesList.Count}");
            FillingBudgets(listofExpenses, listOfBudgets);
            BudgetsSummary(listOfBudgets);

            static List<Expense> ReadExpensesFromFile()
            {
                List<Expense> result = new List<Expense>();
                var lines = File.ReadAllLines($"Baza.txt");
                foreach (string line in lines)
                {
                    var fields = line.Split(';');
                    var name = fields[0];
                    var expenseValue = Convert.ToDouble(fields[1]);
                    var dateYear = Convert.ToInt16(fields[2]);
                    var dateMonth = Convert.ToInt16(fields[3]);
                    var dateDay = Convert.ToInt16(fields[4]);
                    var date = new DateTime(dateYear, dateMonth, dateDay);
                    var category = fields[5].ToLower();
                    var expense = new Expense(name, expenseValue, date, category);
                    result.Add(expense);
                }
                return result;
            }

            static void FillingBudgets(ListofExpenses listofExpenses, List<Budget> listOfBudgets)
            {
                foreach (Expense e in listofExpenses.GetUnprocessedExpenses())
                {
                    int month = e.Date.Month;
                    int year = e.Date.Year;
                    bool createNewBudget = true;

                    foreach (Budget b in listOfBudgets)
                    {
                        if (b.Year == year && b.Month == month)
                        {
                            b.BudgetIsNowExceeded += b.AlertBudgetGotExceeded;
                            b.AddExpenseToBudget(e);
                            b.IsBudgetExceeded(e);
                            createNewBudget = false;
                            listofExpenses.IncreasesPositionID();
                            b.BudgetIsNowExceeded -= b.AlertBudgetGotExceeded;
                        }
                    }

                    if (createNewBudget)
                    {
                        Budget newBudget = new Budget(month, year);
                        newBudget.BudgetIsNowExceeded += newBudget.AlertBudgetGotExceeded;
                        newBudget.AddExpenseToBudget(e);
                        newBudget.IsBudgetExceeded(e);
                        listOfBudgets.Add(newBudget);
                        createNewBudget = false;
                        listofExpenses.IncreasesPositionID();
                        newBudget.BudgetIsNowExceeded -= newBudget.AlertBudgetGotExceeded;
                    }
                }
            }

            static void BudgetsSummary(List<Budget> listOfBudgets)
            {
                int i = 1;
                listOfBudgets.Sort();
                Console.WriteLine("");
                foreach (Budget b in listOfBudgets)
                {
                    DateTime date = new DateTime(b.Year, b.Month, 1);
                    Console.WriteLine($"{i:D2}: {b.Year} - {b.Month:D2} {date.ToString("MMMM"),-15} - Food: count {b.FoodExpensesInBudget.Count:D2}; value: {b.FoodSum,10:N2}{";",-5}{"||",-5}Bills: count: {b.BillsExpensesInBudget.Count:D2}; value {b.BillsSum,10:N2}{";",-5}{"||",-5}Pleasures: count: {b.PleasuresExpensesInBudget.Count:D2}; value: {b.PleasuresSum,10:N2};");
                    i++;
                }
                Console.WriteLine("");
            }           
        }
    }
}