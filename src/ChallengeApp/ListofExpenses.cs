using System;
using System.Collections.Generic;
using System.IO;

namespace ChallengeApp
{
    public class ListofExpenses
    {
        public List<Expense> expensesList = new List<Expense>();
        public int NumberOfProcessedExpenses { get; private set; } = 0;
        public void AddExpense(Expense expense)
        {
            this.expensesList.Add(expense);
        }
        public void AddListofExpenses(List<Expense> expenses)
        {
            this.expensesList.AddRange(expenses);
        }
        public List<Expense> GetUnprocessedExpenses()
        {
            if (expensesList.Count == 0)
            {
                return new List<Expense>();
            }
            else
            {
                return expensesList.GetRange(NumberOfProcessedExpenses, expensesList.Count - NumberOfProcessedExpenses);
            }
        }
        public void IncreasesPositionID()
        {
            NumberOfProcessedExpenses++;
        }
        public void AddExpenseToListInFileAndMemory()
        {
            using (var writer = File.AppendText($"Baza.txt"))
            {
                string input;
                do
                {
                    Console.WriteLine($"\nInsert expense name");
                    string name = Console.ReadLine();

                    Console.WriteLine($"\nInsert expense value");
                    double expenseValue = InsertExpenseValue();

                    Console.WriteLine($"\nInsert date of expense  in format YYYY-MM-DD");
                    DateTime date = InsertExpenseDate();

                    Console.WriteLine($"\nInsert expense Category - choose from \"food\",\"bills\", \"pleasures\"");
                    string category = InsertExpenseCategory();

                    Expense newexpense = new Expense(name, expenseValue, date, category);
                    expensesList.Add(newexpense);

                    writer.WriteLine($"{name};{expenseValue};{date.Year};{date.Month};{date.Day};{category}");

                    Console.WriteLine($"\nYour expense \"{name}\" has been added to list (value:{expenseValue}, category: \"{category}\")");
                    Console.WriteLine($"\nDo you want to add another expense <Y/N>");
                    do
                    {
                        input = Console.ReadLine().ToUpper();
                        if (input == "Y")
                        {
                            Console.WriteLine($"\nPlease insert another expense details\n");
                        }
                        else if (input == "N")
                        {
                            Console.WriteLine($"\nBelow you will be informed in detail with a summary of the budgets");
                        }
                        else { Console.WriteLine($"\nPlease insert correct value - Y or N"); }
                    }
                    while (!(input == "Y" || input == "N"));
                }
                while (input == "Y");
            }
        }
        private double InsertExpenseValue()
        {
            double expenseValue = -1;
            do
            {
                try
                {
                    string value = Console.ReadLine();
                    if (double.TryParse(value, out double correctValue))
                    {
                        expenseValue = correctValue;
                        if (expenseValue <= 0)
                        {
                            Console.WriteLine("Please insert positive value");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please insert correct value");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (expenseValue <= 0);
            return expenseValue;
        }
        private DateTime InsertExpenseDate()
        {
            DateTime date = new DateTime(1, 1, 1);
            do
            {
                try
                {
                    string dateAsDate = Console.ReadLine();
                    if (DateTime.TryParse(dateAsDate, out DateTime correctDate) == true)
                    {
                        date = correctDate;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please insert date in correct format");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (date.Year == 1);
            return date;
        }
        private string InsertExpenseCategory()
        {
            string category;
            do
            {
                category = Console.ReadLine().ToLower();
                if (category == "food" || category == "bills" || category == "pleasures")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Insert correct category - choose from \"food\",\"bills\", \"pleasures\"");
                }
            }
            while (true);
            return category;
        }
    }
}