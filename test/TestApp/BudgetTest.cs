using ChallengeApp;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;


namespace TestApp
{
    public class BudgetTest
    {
        [Fact]
        public void Test1CompareTo()
        {
            //arrange
            Budget buget1 = new Budget(12, 2022);
            Budget buget2 = new Budget(11, 2022);
            Budget buget3 = new Budget(11, 2021);
            List<Budget> list = new List<Budget>();
            list.Add(buget1);
            list.Add(buget2);
            list.Add(buget3);
            //act
            list.Sort();
            //assert
            Assert.Equal(11, list[0].Month);
            Assert.Equal(2021, list[0].Year);
            Assert.Equal(12, list[2].Month);
        }

        [Fact]
        public void Test2AddExpenseToBudget()
        {
            //arrange
            Budget b = new Budget(12, 2022);
            Expense exp1 = new Expense("food", 300, new DateTime(2022, 12, 12), "food");
            Expense exp2 = new Expense("bills", 400, new DateTime(2022, 12, 13), "bills");
            Expense exp3 = new Expense("pleasures", 500, new DateTime(2022, 12, 14), "pleasures");
            Expense exp4 = new Expense("pleasures2", 600, new DateTime(2022, 12, 15), "pleasures");

            //act
            b.AddExpenseToBudget(exp1);
            b.AddExpenseToBudget(exp2);
            b.AddExpenseToBudget(exp3);
            b.AddExpenseToBudget(exp4);

            //assert
            Assert.Equal(1100, b.PleasuresSum);
            Assert.Contains(exp4, b.PleasuresExpensesInBudget);
        }

        [Fact]
        public void Test3IsBudgetExceeded()
        {
            // arrange
            Budget b = new Budget(12, 2022);
            Expense exp1 = new Expense("food", 1500, new DateTime(2022, 12, 12), "food");
            Expense exp2 = new Expense("food", 600, new DateTime(2022, 12, 12), "food");
            Expense exp3 = new Expense("bills", 1000, new DateTime(2022, 12, 13), "bills");
            Expense exp4 = new Expense("pleasures", 1499, new DateTime(2022, 12, 14), "pleasures");
            b.AddExpenseToBudget(exp1);
            b.AddExpenseToBudget(exp2);
            b.AddExpenseToBudget(exp3);
            b.AddExpenseToBudget(exp4);

            // act
            b.IsBudgetExceeded(exp1);
            b.IsBudgetExceeded(exp2);
            b.IsBudgetExceeded(exp3);
            b.IsBudgetExceeded(exp4);

            // assert
            Assert.True(b.FoodBudgetIsExceeded);
            Assert.False(b.BillsBudgetIsExceeded);
            Assert.True(b.PleasuresBudgetIsExceeded);
            Assert.False(b.FoodBudgetWasExceededWithLastExpense);
            Assert.False(b.BillsBudgetWasExceededWithLastExpense);
            Assert.False(b.PleasuresBudgetWasExceededWithLastExpense);
        }
    }
}
