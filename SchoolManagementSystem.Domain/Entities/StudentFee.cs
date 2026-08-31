using SchoolManagementSystem.Domain.Common;

namespace SchoolManagementSystem.Domain.Entities;

public class StudentFee : AuditableEntity
{
    public int StudentId { get; set; }

    public int FeeStructureId { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal PaidAmount { get; set; }

    public decimal DueAmount { get; set; }

    public string Status { get; set; } = string.Empty;
}