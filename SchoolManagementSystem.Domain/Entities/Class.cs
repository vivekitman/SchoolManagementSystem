using SchoolManagementSystem.Domain.Common;

namespace SchoolManagementSystem.Domain.Entities;

public class Class : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }
}