namespace SchoolManagementSystem.Application.Common.Interfaces;

public interface ICurrentUserService
{
    int? UserId { get; }

    string? UserName { get; }

    IEnumerable<string> Roles { get; }
}