using System;
using System.Collections.Generic;   // dodać aby móc używać LIST

namespace ChallengeApp
{
    public class ListofExpenses
    {
        public List<StandardExpense> expensesList = new List<StandardExpense>();
        public int PositionID { get; private set; } = 0;
        public void AddExpense(StandardExpense expense)
        {
            this.expensesList.Add(expense);
        }
        public void AddListofExpenses(List<StandardExpense> expenses)
        {
            this.expensesList.AddRange(expenses);
        }
        public List<StandardExpense> GetUnprocessedExpenses()
        {
            if (expensesList.Count == 0)
            {
                return new List<StandardExpense>();
            }
            else
            {
                return expensesList.GetRange(PositionID, expensesList.Count - PositionID);
            }
        }
        public void IncreasesPositionID()
        {
            PositionID++;
        }

        public Statistics getStats()
        {
            var result = new Statistics();

            result.Avg = 0.0;
            result.Sum = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var expense in this.expensesList)
            {
                result.Low = Math.Min(result.Low, expense.Value);
                result.High = Math.Max(result.High, expense.Value);
                result.Sum += expense.Value;
            }
            result.Avg = result.Sum / this.expensesList.Count;

            Console.WriteLine("Najniższa ocena to " + result.Low.ToString("N2"));
            Console.WriteLine("Najwyższa ocena to " + result.High.ToString("N2"));
            Console.WriteLine("Średnia ocen to " + result.Avg.ToString("N2"));

            return result;
        }
        public void AddExpenseToListIO()
        {
            Console.WriteLine($"Insert expense name");
            string name = Console.ReadLine();
            Console.WriteLine($"Insert expense value");
            string value = Console.ReadLine();
            if (!double.TryParse(value, out double correctValue))
            {
                throw new Exception($"incorrect value");
            }
            Console.WriteLine($"Insert expense date in format YYYY-MM-DD");
            string date = Console.ReadLine();
            DateTime correctdate = DateTime.ParseExact(date, "yyyy-MM-dd", null);
            Console.WriteLine($"Insert expense Category - choose form \"Food\",\"Bills\", \"Pleasures\"");
            string category = Console.ReadLine();
            StandardExpense newexpense = new StandardExpense(name, correctValue, correctdate, category);
            expensesList.Add(newexpense);

            var lastIndexOflist = expensesList.Count - 1;                       //test
            Console.WriteLine(expensesList[lastIndexOflist].Name);              //test

        }
    }
}