using System.ComponentModel.DataAnnotations;

namespace EasyFinance.Entities.Dtos;

public record ExpenseCategoryDto(
    [Required(ErrorMessage = "O nome é obrigatório.")]
    string ExpenseCategoryName
    );