namespace SchoolManagementSystem.Application.Common.Interfaces;

public interface IFileStorageService
{
    Task<string> SavePdfAsync(
        Stream stream,
        string originalFileName,
        CancellationToken cancellationToken);

    Task DeleteAsync(
        string fileName,
        CancellationToken cancellationToken);

    Task<Stream?> GetAsync(
        string fileName,
        CancellationToken cancellationToken);
}