using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Creating and filling list of expenses with example data
            ListofExpenses listofExpenses = new ListofExpenses();

            listofExpenses.AddListofExpenses(new List<StandardExpense>
            {
            new StandardExpense("Lidl", 363.0, new DateTime(2021, 1, 24), "Food"),
            new StandardExpense("Biedronka", 300.0, new DateTime(2021, 1, 29), "Food"),
            new StandardExpense("L.Eclerc", 306.0, new DateTime(2021, 1, 9), "Food"),
            new StandardExpense("Electricity", 406.0, new DateTime(2021, 1, 11), "Bills"),
            new StandardExpense("Gas", 483.0, new DateTime(2021, 1, 6), "Bills"),
            new StandardExpense("Water", 422.0, new DateTime(2021, 1, 10), "Bills"),
            new StandardExpense("Cinema", 368.0, new DateTime(2021, 1, 1), "Pleasures"),
            new StandardExpense("Books", 148.0, new DateTime(2021, 1, 6), "Pleasures"),
            new StandardExpense("Lidl", 316.0, new DateTime(2021, 1, 23), "Food"),
            new StandardExpense("Lidl", 462.0, new DateTime(2021, 2, 10), "Food"),
            new StandardExpense("Biedronka", 332.0, new DateTime(2021, 2, 15), "Food"),
            new StandardExpense("L.Eclerc", 492.0, new DateTime(2021, 2, 22), "Food"),
            new StandardExpense("Electricity", 428.0, new DateTime(2021, 2, 4), "Bills"),
            new StandardExpense("Gas", 393.0, new DateTime(2021, 2, 13), "Bills"),
            new StandardExpense("Water", 575.0, new DateTime(2021, 2, 28), "Bills"),
            new StandardExpense("Cinema", 333.0, new DateTime(2021, 2, 6), "Pleasures"),
            new StandardExpense("Books", 354.0, new DateTime(2021, 2, 15), "Pleasures"),
            new StandardExpense("Theatre", 186.0, new DateTime(2021, 2, 12), "Pleasures"),
            new StandardExpense("Concert", 195.0, new DateTime(2021, 2, 22), "Pleasures"),
            new StandardExpense("Lidl", 409.0, new DateTime(2021, 2, 27), "Food"),
            new StandardExpense("Lidl", 304.0, new DateTime(2021, 3, 24), "Food"),
            new StandardExpense("Biedronka", 517.0, new DateTime(2021, 3, 17), "Food"),
            new StandardExpense("L.Eclerc", 304.0, new DateTime(2021, 3, 25), "Food"),
            new StandardExpense("Electricity", 598.0, new DateTime(2021, 3, 28), "Bills"),
            new StandardExpense("Gas", 364.0, new DateTime(2021, 3, 30), "Bills"),
            new StandardExpense("Water", 574.0, new DateTime(2021, 3, 19), "Bills"),
            new StandardExpense("Cinema", 321.0, new DateTime(2021, 3, 26), "Pleasures"),
            new StandardExpense("Books", 224.0, new DateTime(2021, 3, 2), "Pleasures"),
            new StandardExpense("Lidl", 458.0, new DateTime(2021, 3, 20), "Food"),
            new StandardExpense("Lidl", 459.0, new DateTime(2021, 4, 30), "Food"),
            new StandardExpense("Biedronka", 360.0, new DateTime(2021, 4, 16), "Food"),
            new StandardExpense("L.Eclerc", 544.0, new DateTime(2021, 4, 16), "Food"),
            new StandardExpense("Electricity", 378.0, new DateTime(2021, 4, 28), "Bills"),
            new StandardExpense("Gas", 495.0, new DateTime(2021, 4, 11), "Bills"),
            new StandardExpense("Water", 615.0, new DateTime(2021, 4, 13), "Bills"),
            new StandardExpense("Cinema", 318.0, new DateTime(2021, 4, 2), "Pleasures"),
            new StandardExpense("Books", 346.0, new DateTime(2021, 4, 8), "Pleasures"),
            new StandardExpense("Lidl", 374.0, new DateTime(2021, 4, 8), "Food"),
            new StandardExpense("Lidl", 640.0, new DateTime(2021, 5, 14), "Food"),
            new StandardExpense("Biedronka", 465.0, new DateTime(2021, 5, 14), "Food"),
            new StandardExpense("L.Eclerc", 315.0, new DateTime(2021, 5, 16), "Food"),
            new StandardExpense("Electricity", 565.0, new DateTime(2021, 5, 18), "Bills"),
            new StandardExpense("Gas", 478.0, new DateTime(2021, 5, 17), "Bills"),
            new StandardExpense("Water", 435.0, new DateTime(2021, 5, 3), "Bills"),
            new StandardExpense("Cinema", 165.0, new DateTime(2021, 5, 23), "Pleasures"),
            new StandardExpense("Books", 349.0, new DateTime(2021, 5, 24), "Pleasures"),
            new StandardExpense("Lidl", 337.0, new DateTime(2021, 5, 7), "Food"),
            new StandardExpense("Lidl", 482.0, new DateTime(2021, 6, 18), "Food"),
            new StandardExpense("Biedronka", 321.0, new DateTime(2021, 6, 17), "Food"),
            new StandardExpense("L.Eclerc", 509.0, new DateTime(2021, 6, 18), "Food"),
            new StandardExpense("Electricity", 622.0, new DateTime(2021, 6, 29), "Bills"),
            new StandardExpense("Gas", 484.0, new DateTime(2021, 6, 13), "Bills"),
            new StandardExpense("Water", 575.0, new DateTime(2021, 6, 16), "Bills"),
            new StandardExpense("Cinema", 304.0, new DateTime(2021, 6, 3), "Pleasures"),
            new StandardExpense("Books", 391.0, new DateTime(2021, 6, 11), "Pleasures"),
            new StandardExpense("Lidl", 568.0, new DateTime(2021, 6, 17), "Food"),
            new StandardExpense("Lidl", 321.0, new DateTime(2021, 7, 28), "Food"),
            new StandardExpense("Biedronka", 578.0, new DateTime(2021, 7, 29), "Food"),
            new StandardExpense("L.Eclerc", 644.0, new DateTime(2021, 7, 30), "Food"),
            new StandardExpense("Electricity", 540.0, new DateTime(2021, 7, 5), "Bills"),
            new StandardExpense("Gas", 553.0, new DateTime(2021, 7, 22), "Bills"),
            new StandardExpense("Water", 579.0, new DateTime(2021, 7, 21), "Bills"),
            new StandardExpense("Cinema", 198.0, new DateTime(2021, 7, 26), "Pleasures"),
            new StandardExpense("Books", 199.0, new DateTime(2021, 7, 27), "Pleasures"),
            new StandardExpense("Lidl", 426.0, new DateTime(2021, 7, 30), "Food"),
            new StandardExpense("Lidl", 437.0, new DateTime(2021, 8, 24), "Food"),
            new StandardExpense("Biedronka", 630.0, new DateTime(2021, 8, 9), "Food"),
            new StandardExpense("L.Eclerc", 510.0, new DateTime(2021, 8, 15), "Food"),
            new StandardExpense("Electricity", 445.0, new DateTime(2021, 8, 8), "Bills"),
            new StandardExpense("Gas", 465.0, new DateTime(2021, 8, 10), "Bills"),
            new StandardExpense("Water", 439.0, new DateTime(2021, 8, 17), "Bills"),
            new StandardExpense("Cinema", 259.0, new DateTime(2021, 8, 12), "Pleasures"),
            new StandardExpense("Books", 150.0, new DateTime(2021, 8, 17), "Pleasures"),
            new StandardExpense("Lidl", 629.0, new DateTime(2021, 8, 8), "Food"),
            new StandardExpense("Lidl", 361.0, new DateTime(2021, 9, 8), "Food"),
            new StandardExpense("Biedronka", 287.0, new DateTime(2021, 9, 28), "Food"),
            new StandardExpense("L.Eclerc", 646.0, new DateTime(2021, 9, 26), "Food"),
            new StandardExpense("Electricity", 546.0, new DateTime(2021, 9, 29), "Bills"),
            new StandardExpense("Gas", 389.0, new DateTime(2021, 9, 16), "Bills"),
            new StandardExpense("Water", 371.0, new DateTime(2021, 9, 3), "Bills"),
            new StandardExpense("Cinema", 334.0, new DateTime(2021, 9, 8), "Pleasures"),
            new StandardExpense("Books", 395.0, new DateTime(2021, 9, 2), "Pleasures"),
            new StandardExpense("Lidl", 355.0, new DateTime(2021, 9, 6), "Food"),
            new StandardExpense("Lidl", 399.0, new DateTime(2021, 10, 5), "Food"),
            new StandardExpense("Biedronka", 593.0, new DateTime(2021, 10, 12), "Food"),
            new StandardExpense("L.Eclerc", 282.0, new DateTime(2021, 10, 30), "Food"),
            new StandardExpense("Electricity", 428.0, new DateTime(2021, 10, 26), "Bills"),
            new StandardExpense("Gas", 350.0, new DateTime(2021, 10, 29), "Bills"),
            new StandardExpense("Water", 370.0, new DateTime(2021, 10, 12), "Bills"),
            new StandardExpense("Cinema", 268.0, new DateTime(2021, 10, 12), "Pleasures"),
            new StandardExpense("Books", 106.0, new DateTime(2021, 10, 9), "Pleasures"),
            new StandardExpense("Lidl", 538.0, new DateTime(2021, 10, 2), "Food"),
            new StandardExpense("Lidl", 538.0, new DateTime(2021, 11, 18), "Food"),
            new StandardExpense("Biedronka", 533.0, new DateTime(2021, 11, 12), "Food"),
            new StandardExpense("L.Eclerc", 565.0, new DateTime(2021, 11, 3), "Food"),
            new StandardExpense("Electricity", 602.0, new DateTime(2021, 11, 26), "Bills"),
            new StandardExpense("Gas", 595.0, new DateTime(2021, 11, 4), "Bills"),
            new StandardExpense("Water", 585.0, new DateTime(2021, 11, 14), "Bills"),
            new StandardExpense("Cinema", 102.0, new DateTime(2021, 11, 7), "Pleasures"),
            new StandardExpense("Books", 245.0, new DateTime(2021, 11, 23), "Pleasures"),
            new StandardExpense("Lidl", 426.0, new DateTime(2021, 11, 6), "Food"),
            new StandardExpense("Lidl", 623.0, new DateTime(2021, 12, 4), "Food"),
            new StandardExpense("Biedronka", 621.0, new DateTime(2021, 12, 23), "Food"),
            new StandardExpense("L.Eclerc", 638.0, new DateTime(2021, 12, 23), "Food"),
            new StandardExpense("Electricity", 540.0, new DateTime(2021, 12, 5), "Bills"),
            new StandardExpense("Gas", 374.0, new DateTime(2021, 12, 18), "Bills"),
            new StandardExpense("Water", 392.0, new DateTime(2021, 12, 20), "Bills"),
            new StandardExpense("Cinema", 254.0, new DateTime(2021, 12, 26), "Pleasures"),
            new StandardExpense("Books", 130.0, new DateTime(2021, 12, 6), "Pleasures"),
            new StandardExpense("Lidl", 633.0, new DateTime(2021, 12, 18), "Food"),
            new StandardExpense("Lidl", 396.0, new DateTime(2022, 1, 6), "Food"),
            new StandardExpense("Biedronka", 347.0, new DateTime(2022, 1, 28), "Food"),
            new StandardExpense("L.Eclerc", 486.0, new DateTime(2022, 1, 22), "Food"),
            new StandardExpense("Electricity", 601.0, new DateTime(2022, 1, 1), "Bills"),
            new StandardExpense("Gas", 475.0, new DateTime(2022, 1, 21), "Bills"),
            new StandardExpense("Water", 598.0, new DateTime(2022, 1, 11), "Bills"),
            new StandardExpense("Cinema", 104.0, new DateTime(2022, 1, 9), "Pleasures"),
            new StandardExpense("Books", 234.0, new DateTime(2022, 1, 18), "Pleasures"),
            new StandardExpense("Lidl", 406.0, new DateTime(2022, 1, 19), "Food"),
            new StandardExpense("Lidl", 624.0, new DateTime(2022, 2, 11), "Food"),
            new StandardExpense("Biedronka", 408.0, new DateTime(2022, 2, 25), "Food"),
            new StandardExpense("L.Eclerc", 504.0, new DateTime(2022, 2, 6), "Food"),
            new StandardExpense("Electricity", 366.0, new DateTime(2022, 2, 3), "Bills"),
            new StandardExpense("Gas", 600.0, new DateTime(2022, 2, 16), "Bills"),
            new StandardExpense("Water", 556.0, new DateTime(2022, 2, 11), "Bills"),
            new StandardExpense("Cinema", 226.0, new DateTime(2022, 2, 10), "Pleasures"),
            new StandardExpense("Books", 309.0, new DateTime(2022, 2, 7), "Pleasures"),
            new StandardExpense("Lidl", 452.0, new DateTime(2022, 2, 12), "Food"),
            new StandardExpense("Lidl", 523.0, new DateTime(2022, 3, 15), "Food"),
            new StandardExpense("Biedronka", 461.0, new DateTime(2022, 3, 12), "Food"),
            new StandardExpense("L.Eclerc", 296.0, new DateTime(2022, 3, 15), "Food"),
            new StandardExpense("Electricity", 537.0, new DateTime(2022, 3, 4), "Bills"),
            new StandardExpense("Gas", 560.0, new DateTime(2022, 3, 1), "Bills"),
            new StandardExpense("Water", 532.0, new DateTime(2022, 3, 29), "Bills"),
            new StandardExpense("Cinema", 103.0, new DateTime(2022, 3, 17), "Pleasures"),
            new StandardExpense("Books", 211.0, new DateTime(2022, 3, 8), "Pleasures"),
            new StandardExpense("Lidl", 580.0, new DateTime(2022, 3, 5), "Food"),
            new StandardExpense("Books", 226.0, new DateTime(2022, 3, 16), "Pleasures"),
            });

            // 2. Creating budgets for list of my expenses
            List<Budget> listOfBudgets = new List<Budget>();
            FillingBudgets(listofExpenses, listOfBudgets);

            // 3. Adding my new expenses from console !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            listofExpenses.AddExpenseToListIO();   //zakomentować na testy

            // ExpenseAddedToBudgetDelegate del = ;  // delegat
            // ExpenseAddedToBudgetEvent += del;     // event

            // 3A.
            StandardExpense NewEXP = new StandardExpense("no139", 666, new DateTime(2022, 4, 6), "Pleasures");
            listofExpenses.expensesList.Add(NewEXP);

            StandardExpense NewEXP2 = new StandardExpense("no140", 666, new DateTime(2022, 4, 6), "Pleasures");
            listofExpenses.expensesList.Add(NewEXP2);

            StandardExpense NewEXP3 = new StandardExpense("no141", 677, new DateTime(2022, 4, 6), "Pleasures");
            listofExpenses.expensesList.Add(NewEXP3);


            // test tymczasowy
            Console.WriteLine($"liczba pozycji na liście wydatków: {listofExpenses.expensesList.Count}");

            //4. Checking if new expenses need new budgets and creating needed new budget
            FillingBudgets(listofExpenses, listOfBudgets);



            //5. test utworzonych budzetów
            BudgetsSummary(listOfBudgets);

            //6. test getstats
            listofExpenses.getStats();

        }
        //Chciałbym to wywoływac eventem, ale nie wiem do czego ma się odwoływac event -do budżeu czy wydatku?
        static void BudgetsSummary(List<Budget> listOfBudgets)
        {
            int i = 1;
            foreach (Budget b in listOfBudgets)
            {
                Console.WriteLine($"{i}:\t {b.BudgetYear} {b.BudgetMonth} - \tFood: count{b.expensesInBudgetFood.Count}, value: {b.FoodSum};\tBills: count: {b.expensesInBudgetBills.Count}, value {b.BillsSum};\tPleasures: count: {b.expensesInBudgetPleasures.Count}, value: {b.PleasuresSum};");
                i++;
            }
        }

        public static void FillingBudgets(ListofExpenses listofExpenses, List<Budget> listOfBudgets)
        {
            foreach (StandardExpense e in listofExpenses.GetUnprocessedExpenses())
            {
                int month = e.Date.Month;
                int year = e.Date.Year;
                bool createNewBudget = true;

                foreach (Budget b in listOfBudgets)
                {
                    if (b.BudgetYear == year && b.BudgetMonth == month)
                    {
                        b.AddExpenseToBudget(e);
                        listofExpenses.IncreasesPositionID();
                        // if (ExpenseAddedToBudgetEvent != null)
                        // {
                            // ExpenseAddedToBudgetEvent(this);
                        // }
                        createNewBudget = false;
                    }
                }

                if (createNewBudget)
                {
                    Budget newBudget = new Budget(month, year);
                    newBudget.AddExpenseToBudget(e);
                    listOfBudgets.Add(newBudget);
                    // if (ExpenseAddedToBudgetEvent != null)
                    // {
                        // ExpenseAddedToBudgetEvent(e);
                    // }
                    createNewBudget = false;
                    listofExpenses.IncreasesPositionID();
                }



            }

        }
        public delegate void ExpenseAddedToBudgetDelegate(object sender, EventArgs args);
        static event ExpenseAddedToBudgetDelegate ExpenseAddedToBudgetEvent;
    }
}




