using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Api.DTOs;

public class CreateTicketDto
{
    [Required(ErrorMessage = "Title is required.")]
    [StringLength(100, MinimumLength = 5)]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required.")]
    [StringLength(1000, MinimumLength = 10)]
    public string Description { get; set; } = string.Empty;

    [Required]
    [RegularExpression("^(Low|Medium|High|Critical)$")]
    public string Priority { get; set; } = "Medium";
}