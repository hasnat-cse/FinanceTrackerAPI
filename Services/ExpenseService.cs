using FinanceTrackerAPI.Models;

namespace FinanceTrackerAPI.Services;

public static class ExpenseService
{
    private static List<Expense> Expenses { get; }
    static ExpenseService()
    {
        Expenses =
        [
            new Expense
            {
                Id = 1,
                Description = "Rent",
                Amount = 1000,
                Category = "Housing",
                Date = DateTime.Now
            },
            new Expense
            {
                Id = 2,
                Description = "Groceries",
                Amount = 200,
                Category = "Food",
                Date = DateTime.Now
            }
        ];
    }

    public static List<Expense> GetAll() => Expenses;
}
