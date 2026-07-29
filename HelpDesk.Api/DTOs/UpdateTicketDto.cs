using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Api.DTOs;

public class UpdateTicketDto
{
    [Required(ErrorMessage = "Title is required.")]
    [StringLength(
        100,
        MinimumLength = 5,
        ErrorMessage = "Title must be between 5 and 100 characters."
    )]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required.")]
    [StringLength(
        1000,
        MinimumLength = 10,
        ErrorMessage = "Description must be between 10 and 1000 characters."
    )]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Priority is required.")]
    [RegularExpression(
        "^(Low|Medium|High|Critical)$",
        ErrorMessage = "Priority must be Low, Medium, High, or Critical."
    )]
    public string Priority { get; set; } = "Medium";

    [Required(ErrorMessage = "Status is required.")]
    [RegularExpression(
        "^(Open|In Progress|Resolved|Closed)$",
        ErrorMessage = "Status must be Open, In Progress, Resolved, or Closed."
    )]
    public string Status { get; set; } = "Open";
}