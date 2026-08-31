using SchoolManagementSystem.Domain.Common;
using SchoolManagementSystem.Domain.Enums;

namespace SchoolManagementSystem.Domain.Entities;

public class Document : AuditableEntity
{
    public int StudentId { get; set; }

    public DocumentType DocumentType { get; set; }

    public string OriginalFileName { get; set; } = string.Empty;

    public string StoredFileName { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;

    public string ContentType { get; set; } = "application/pdf";

    public long FileSize { get; set; }
}