using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Application.Features.Students.Commands.CreateStudent;
using SchoolManagementSystem.Application.Features.Students.Queries.GetStudents;

namespace SchoolManagementSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class StudentsController : ControllerBase
{
    private readonly IMediator _mediator;

    public StudentsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Authorize(Roles = "Admin,Principal,Receptionist")]
    public async Task<IActionResult> Create(
        CreateStudentCommand command)
    {
        var id = await _mediator.Send(command);

        return Ok(new
        {
            Success = true,
            Message = "Student created successfully.",
            Data = id
        });
    }

    [HttpGet]
    [Authorize(Roles = "Admin,Principal,Teacher,Receptionist")]
    public async Task<IActionResult> GetAll(
        int pageNumber = 1,
        int pageSize = 10,
        string? search = null)
    {
        var result = await _mediator.Send(
            new GetStudentsQuery(
                pageNumber,
                pageSize,
                search));

        return Ok(result);
    }
}