namespace TaskManagement.Models.Entities.Person;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

public class PersonViewModel
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, ErrorMessage = "Name must be at most 100 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Job is required.")]
    public string Job { get; set; }

    // numeric value constraint AND digit-count constraint using regex (2-3 digits)
    [Required(ErrorMessage = "Salary is required.")]
    [Range(10, 100, ErrorMessage = "Salary must be between 10 and 100.")]
    [RegularExpression(@"^\d{2,3}$", ErrorMessage = "Salary must be 2–3 digits.")]
    public int Salary { get; set; }

    [Remote(action: "IsEmailAvailable", controller: "Account", ErrorMessage = "Email already in use.")]
    public string Email { get; set; }

    public DateTime StartDateTime {  get; set; }
    public DateTime EndDateTime {  get; set; }
}

