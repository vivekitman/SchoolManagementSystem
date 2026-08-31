using FluentValidation;

namespace SchoolManagementSystem.Application.Features.Students.Commands.CreateStudent;

public class CreateStudentCommandValidator
    : AbstractValidator<CreateStudentCommand>
{
    public CreateStudentCommandValidator()
    {
        RuleFor(x => x.AdmissionNumber)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.LastName)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.DateOfBirth)
            .LessThan(DateTime.UtcNow);

        RuleFor(x => x.ParentId)
            .GreaterThan(0);

        RuleFor(x => x.ClassId)
            .GreaterThan(0);

        RuleFor(x => x.SectionId)
            .GreaterThan(0);

        RuleFor(x => x.Email)
            .EmailAddress()
            .When(x => !string.IsNullOrWhiteSpace(x.Email));
    }
}