namespace  EasyFinance.Entities;
public class Expense
{
    public Guid ExpenseId { get; set; } = Guid.NewGuid();
    public string Description { get; set; }
    public int ExpenseValue { get; set; }
    public Guid ExpenseCategoryId { get; set; }
    public ExpenseCategory ExpenseCategory { get; set; }

    public Expense() { }

    public Expense(string Description, int ExpenseValue, ExpenseCategory ExpenseCategory)
    {
        this.Description = Description;
        this.ExpenseValue = ExpenseValue;
        this.ExpenseCategory = ExpenseCategory;
        this.ExpenseCategoryId = ExpenseCategory.ExpenseCategoryId;
    }


}