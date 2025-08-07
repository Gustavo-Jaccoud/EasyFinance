using EasyFinance.Entities;
using EasyFinance.Entities.Dtos;

namespace EasyFinance.Repositories;

public interface IExpenseCategoryRepository
{

    Task<IEnumerable<ExpenseCategory>> GetAll();
    Task<ExpenseCategory> Create(ExpenseCategoryDto expenseCategoryDto);
    Task<ExpenseCategory> GetById(Guid expenseCategoryID);
    Task<ExpenseCategory> Update(Guid expenseCategoryID, ExpenseCategoryDto expenseCategoryDto);
    Task<ExpenseCategory> Delete(Guid expenseCategoryID);



}