namespace  EasyFinance.Entities;
public class ExpenseCategory
{
    public Guid ExpenseCategoryId { get; set; } = Guid.NewGuid();
    public string ExpenseCategoryName { get; set; }

    public ExpenseCategory(string ExpenseCategoryName)
    {
        this.ExpenseCategoryName = ExpenseCategoryName;
    }

   public ExpenseCategory() { }
}