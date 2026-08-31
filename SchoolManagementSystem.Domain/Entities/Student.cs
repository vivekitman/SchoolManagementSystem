using SchoolManagementSystem.Domain.Common;
using SchoolManagementSystem.Domain.Enums;

namespace SchoolManagementSystem.Domain.Entities;

public class Student : AuditableEntity
{
    public string AdmissionNumber { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public Gender Gender { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public int ParentId { get; set; }

    public int ClassId { get; set; }

    public int SectionId { get; set; }

    public DateTime AdmissionDate { get; set; }

    public string? Address { get; set; }
}