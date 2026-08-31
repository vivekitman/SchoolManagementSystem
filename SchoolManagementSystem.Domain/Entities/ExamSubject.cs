using SchoolManagementSystem.Domain.Common;

namespace SchoolManagementSystem.Domain.Entities;

public class Exam : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public int AcademicYearId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}