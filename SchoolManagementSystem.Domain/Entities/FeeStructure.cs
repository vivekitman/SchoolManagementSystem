using SchoolManagementSystem.Domain.Common;

namespace SchoolManagementSystem.Domain.Entities;

public class FeeStructure : AuditableEntity
{
    public string FeeName { get; set; } = string.Empty;

    public int ClassId { get; set; }

    public decimal Amount { get; set; }

    public DateTime DueDate { get; set; }
}