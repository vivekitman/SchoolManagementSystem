using Microsoft.Extensions.Configuration;
using SchoolManagementSystem.Application.Common.Interfaces;

namespace SchoolManagementSystem.Infrastructure.FileStorage;

public class LocalFileStorageService : IFileStorageService
{
    private readonly string _rootPath;

    public LocalFileStorageService(
        IConfiguration configuration,
        IWebHostEnvironment environment)
    {
        var configuredPath =
            configuration["FileStorage:RootPath"]
            ?? "wwwroot/uploads/documents";

        _rootPath = Path.Combine(
            environment.ContentRootPath,
            configuredPath);

        Directory.CreateDirectory(_rootPath);
    }

    public async Task<string> SavePdfAsync(
        Stream stream,
        string originalFileName,
        CancellationToken cancellationToken)
    {
        var extension =
            Path.GetExtension(originalFileName);

        if (!string.Equals(
                extension,
                ".pdf",
                StringComparison.OrdinalIgnoreCase))
        {
            throw new InvalidOperationException(
                "Only PDF files are allowed.");
        }

        var storedFileName =
            $"{Guid.NewGuid():N}.pdf";

        var fullPath =
            Path.Combine(_rootPath, storedFileName);

        await using var fileStream =
            new FileStream(
                fullPath,
                FileMode.CreateNew,
                FileAccess.Write,
                FileShare.None);

        await stream.CopyToAsync(
            fileStream,
            cancellationToken);

        return storedFileName;
    }

    public Task DeleteAsync(
        string fileName,
        CancellationToken cancellationToken)
    {
        var fullPath =
            Path.Combine(_rootPath, fileName);

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }

        return Task.CompletedTask;
    }

    public Task<Stream?> GetAsync(
        string fileName,
        CancellationToken cancellationToken)
    {
        var fullPath =
            Path.Combine(_rootPath, fileName);

        if (!File.Exists(fullPath))
            return Task.FromResult<Stream?>(null);

        Stream stream =
            new FileStream(
                fullPath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read);

        return Task.FromResult<Stream?>(stream);
    }
}