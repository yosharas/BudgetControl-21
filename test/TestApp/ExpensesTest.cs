using System;
using Xunit;
using ChallengeApp;


namespace TestApp
{
    public class ExpensesTest
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var exp = new StandardExpense("kawa", 10.0, new DateTime(2022, 12, 22), "food");
            var exp2 = new StandardExpense("Esteban", 2.2, new DateTime(2022, 5, 22), "gas");
            var explist = new ListofExpenses();
            explist.AddExpense(exp);
            explist.AddExpense(exp2);

            //act
            var result = explist.getStats();

            //assert
            Assert.Equal(10.0, result.High);
            Assert.Equal(6.1, result.Avg);
            Assert.Equal(2.2, result.Low);

        }
    }
}
