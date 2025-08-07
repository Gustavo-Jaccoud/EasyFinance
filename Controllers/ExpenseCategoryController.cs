using EasyFinance.Entities.Dtos;
using EasyFinance.Repositories;
using EasyFinance.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyFinance.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ExpenseCategoryController : ControllerBase
{
    private readonly IExpenseCategoryService _service;
    public ExpenseCategoryController(IExpenseCategoryService expenseCategoryService)
    {
        _service = expenseCategoryService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(ExpenseCategoryDto expenseCategoryDto)
    {
        return Ok(await _service.Create(expenseCategoryDto));
    }

}


