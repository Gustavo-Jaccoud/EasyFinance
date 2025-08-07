using EasyFinance.Entities;
using EasyFinance.Entities.Dtos;

namespace EasyFinance.Services;

public interface IExpenseCategoryService
{
    Task<ExpenseCategory> Create(ExpenseCategoryDto expenseCategoryDto);
}