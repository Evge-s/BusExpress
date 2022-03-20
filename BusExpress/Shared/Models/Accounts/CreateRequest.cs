namespace BusExpress.Shared.Models.Accounts;

using System.ComponentModel.DataAnnotations;
using BusExpress.Shared.Entities;

public class CreateRequest
{
    public string? Title { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    [Required]
    [EnumDataType(typeof(Role))]
    public string Role { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}