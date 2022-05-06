using System;

namespace ChallengeApp
{
    public delegate void BudgetExceededDelegate(object sender, EventArgs args);

    public interface IBudgetController
    {
        event BudgetExceededDelegate BudgetIsNowExceeded;
    }
}