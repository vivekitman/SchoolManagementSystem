using MediatR;
using SchoolManagementSystem.Domain.Enums;

namespace SchoolManagementSystem.Application.Features.Students.Commands.CreateStudent;

public record CreateStudentCommand(
    string AdmissionNumber,
    string FirstName,
    string LastName,
    DateTime DateOfBirth,
    Gender Gender,
    string? PhoneNumber,
    string? Email,
    int ParentId,
    int ClassId,
    int SectionId,
    DateTime AdmissionDate,
    string? Address
) : IRequest<int>;