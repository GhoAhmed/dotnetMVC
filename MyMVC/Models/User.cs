using System.ComponentModel.DataAnnotations;

namespace MyMVC.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    public string UserRole { get; set; } // "lessor" or "renter"
}