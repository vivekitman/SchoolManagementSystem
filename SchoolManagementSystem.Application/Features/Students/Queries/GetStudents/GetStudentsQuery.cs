using MediatR;
using SchoolManagementSystem.Application.Common.Models;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Application.Features.Students.Queries.GetStudents;

public record GetStudentsQuery(
    int PageNumber = 1,
    int PageSize = 10,
    string? Search = null
) : IRequest<PagedResult<Student>>;