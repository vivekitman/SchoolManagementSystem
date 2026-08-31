using Dapper;
using MediatR;
using SchoolManagementSystem.Application.Common.Interfaces;
using SchoolManagementSystem.Application.Common.Models;
using SchoolManagementSystem.Domain.Entities;
using System.Data;

namespace SchoolManagementSystem.Application.Features.Students.Queries.GetStudents;

public class GetStudentsQueryHandler
    : IRequestHandler<GetStudentsQuery, PagedResult<Student>>
{
    private readonly IDbConnectionFactory _connectionFactory;

    public GetStudentsQueryHandler(
        IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<PagedResult<Student>> Handle(
        GetStudentsQuery request,
        CancellationToken cancellationToken)
    {
        using var connection =
            _connectionFactory.CreateConnection();

        var parameters = new DynamicParameters();

        parameters.Add("@PageNumber", request.PageNumber);
        parameters.Add("@PageSize", request.PageSize);
        parameters.Add("@Search", request.Search);

        using var multi = await connection.QueryMultipleAsync(
            new CommandDefinition(
                "sp_Students_GetPaged",
                parameters,
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken));

        var students =
            await multi.ReadAsync<Student>();

        var totalRecords =
            await multi.ReadSingleAsync<int>();

        return new PagedResult<Student>
        {
            Items = students,
            PageNumber = request.PageNumber,
            PageSize = request.PageSize,
            TotalRecords = totalRecords
        };
    }
}