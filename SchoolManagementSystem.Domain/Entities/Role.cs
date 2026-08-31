using SchoolManagementSystem.Domain.Common;

namespace SchoolManagementSystem.Domain.Entities;

public class Role : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
}