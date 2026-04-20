using System.ComponentModel.DataAnnotations;

namespace BlazorTestProject.Models;

public class UserModel
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Address { get; set; }
    
    [Required]
    [Range(18, 120)]
    public int Age { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}