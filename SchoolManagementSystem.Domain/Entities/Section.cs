using SchoolManagementSystem.Domain.Common;

namespace SchoolManagementSystem.Domain.Entities;

public class Section : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public int ClassId { get; set; }

    public int Capacity { get; set; }
}