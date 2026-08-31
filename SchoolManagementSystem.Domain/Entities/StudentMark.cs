using SchoolManagementSystem.Domain.Common;

namespace SchoolManagementSystem.Domain.Entities;

public class StudentMark : AuditableEntity
{
    public int StudentId { get; set; }

    public int ExamSubjectId { get; set; }

    public decimal MarksObtained { get; set; }

    public string? Grade { get; set; }

    public string? Remarks { get; set; }
}