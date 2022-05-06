using ChallengeApp;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestApp
{
    public class ListofExpensesTest
    {
        [Fact]
        public void Test1AddExpense()
        {
            //arrange
            ListofExpenses listofExpenses = new();
            Expense expense = new Expense("food", 444, new DateTime(2002, 2, 2), "food");

            //act
            listofExpenses.AddExpense(expense);
            //assert
            Assert.Contains(expense, listofExpenses.expensesList);
        }

        [Fact]
        public void Test2AddListofExpenses()
        {
            //arrange
            ListofExpenses listofExpenses = new();
            Expense exp1 = new Expense("food", 444, new DateTime(2002, 2, 2), "food");
            Expense exp2 = new Expense("gas", 222, new DateTime(2002, 2, 4), "bills");
            List<Expense> testList = new();
            testList.Add(exp1);
            testList.Add(exp2);

            //act
            listofExpenses.AddListofExpenses(testList);

            //assert
            Assert.Contains(exp1, listofExpenses.expensesList);
            Assert.Contains(exp2, listofExpenses.expensesList);

        }

        [Fact]
        public void Test3a_GetUnprocessedExpenses()
        {
            //arrange
            ListofExpenses listofExpenses = new();

            //act
            listofExpenses.GetUnprocessedExpenses();
            //assert
            Assert.Equal(0, listofExpenses.expensesList.Count);
        }

        [Fact]
        public void Test3b_GetUnprocessedExpenses()
        {
            //arrange
            ListofExpenses listofExpenses = new();
            Expense exp1 = new Expense("1", 111, new DateTime(2002, 2, 2), "food");
            Expense exp2 = new Expense("2", 222, new DateTime(2002, 2, 4), "bills");
            Expense exp3 = new Expense("3", 333, new DateTime(2002, 2, 2), "food");
            Expense exp4 = new Expense("4", 444, new DateTime(2002, 2, 4), "bills");

            listofExpenses.AddExpense(exp1);
            listofExpenses.AddExpense(exp2);
            listofExpenses.AddExpense(exp3);
            listofExpenses.AddExpense(exp4);

            listofExpenses.IncreasesPositionID();
            listofExpenses.IncreasesPositionID();

            //act
            List<Expense> testList = listofExpenses.GetUnprocessedExpenses();
            
            //assert
            Assert.Equal(2, testList.Count);
            Assert.Collection(testList, item => Assert.Equal(exp3, item), item => Assert.Equal(exp4, item));
        }
    }
}
