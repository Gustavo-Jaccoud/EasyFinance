using EasyFinance.Entities;
using EasyFinance.Entities.Dtos;
using EasyFinance.Repositories;

namespace EasyFinance.Services;

public class ExpenseCategoryService : IExpenseCategoryService
{
    private readonly IExpenseCategoryRepository _repository;
    public ExpenseCategoryService(IExpenseCategoryRepository repository) {
        _repository = repository;
    }

    public async Task<ExpenseCategory> Create(ExpenseCategoryDto expenseCategoryDto)
    {
        return await _repository.Create(expenseCategoryDto);
    }
}