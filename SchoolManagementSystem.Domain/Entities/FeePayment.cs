using SchoolManagementSystem.Domain.Common;

namespace SchoolManagementSystem.Domain.Entities;

public class FeePayment : AuditableEntity
{
    public int StudentFeeId { get; set; }

    public decimal Amount { get; set; }

    public DateTime PaymentDate { get; set; }

    public string PaymentMode { get; set; } = string.Empty;

    public string? TransactionNumber { get; set; }
}