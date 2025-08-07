using EasyFinance.Context;
using EasyFinance.Entities;
using EasyFinance.Entities.Dtos;

namespace EasyFinance.Repositories;

public class ExpenseCategoryRepository : IExpenseCategoryRepository
{
    private readonly AppDbContext _context;

    public ExpenseCategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ExpenseCategory> Create(ExpenseCategoryDto expenseCategoryDto)
    {
        var category = new ExpenseCategory(expenseCategoryDto.ExpenseCategoryName);
        _context.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public Task<ExpenseCategory> Delete(Guid expenseCategoryID)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ExpenseCategory>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<ExpenseCategory> GetById(Guid expenseCategoryID)
    {
        throw new NotImplementedException();
    }

    public Task<ExpenseCategory> Update(Guid expenseCategoryID, ExpenseCategoryDto expenseCategoryDto)
    {
        throw new NotImplementedException();
    }
}