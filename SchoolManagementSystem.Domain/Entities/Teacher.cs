using SchoolManagementSystem.Domain.Common;
using SchoolManagementSystem.Domain.Enums;

namespace SchoolManagementSystem.Domain.Entities;

public class Teacher : AuditableEntity
{
    public string EmployeeCode { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public Gender Gender { get; set; }

    public string PhoneNumber { get; set; } = string.Empty;

    public string? Email { get; set; }

    public DateTime JoiningDate { get; set; }

    public string? Qualification { get; set; }
}