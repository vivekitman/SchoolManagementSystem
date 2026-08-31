using Dapper;
using MediatR;
using SchoolManagementSystem.Application.Common.Interfaces;
using System.Data;

namespace SchoolManagementSystem.Application.Features.Students.Commands.CreateStudent;

public class CreateStudentCommandHandler
    : IRequestHandler<CreateStudentCommand, int>
{
    private readonly IDbConnectionFactory _connectionFactory;

    public CreateStudentCommandHandler(
        IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<int> Handle(
        CreateStudentCommand request,
        CancellationToken cancellationToken)
    {
        using var connection =
            _connectionFactory.CreateConnection();

        var parameters = new DynamicParameters();

        parameters.Add(
            "@AdmissionNumber",
            request.AdmissionNumber);

        parameters.Add(
            "@FirstName",
            request.FirstName);

        parameters.Add(
            "@LastName",
            request.LastName);

        parameters.Add(
            "@DateOfBirth",
            request.DateOfBirth);

        parameters.Add(
            "@Gender",
            (int)request.Gender);

        parameters.Add(
            "@PhoneNumber",
            request.PhoneNumber);

        parameters.Add(
            "@Email",
            request.Email);

        parameters.Add(
            "@ParentId",
            request.ParentId);

        parameters.Add(
            "@ClassId",
            request.ClassId);

        parameters.Add(
            "@SectionId",
            request.SectionId);

        parameters.Add(
            "@AdmissionDate",
            request.AdmissionDate);

        parameters.Add(
            "@Address",
            request.Address);

        return await connection.ExecuteScalarAsync<int>(
            new CommandDefinition(
                "sp_Students_Create",
                parameters,
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken));
    }
}