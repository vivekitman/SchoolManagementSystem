using SchoolManagementSystem.Domain.Common;
using SchoolManagementSystem.Domain.Enums;

namespace SchoolManagementSystem.Domain.Entities;

public class Attendance : AuditableEntity
{
    public int StudentId { get; set; }

    public DateTime AttendanceDate { get; set; }

    public AttendanceStatus Status { get; set; }

    public string? Remarks { get; set; }
}