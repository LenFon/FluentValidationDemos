using FluentValidation;

namespace FluentValidationDemos.Users.AddUser;

public class AddUserCommandValidator : AbstractValidator<AddUserCommand>
{
    public AddUserCommandValidator()
    {
        RuleFor(r => r.Name).NotEmpty();
        RuleFor(r => r.Name).Length(3, 50);
        RuleFor(r => r.Age).NotEmpty();
    }
}
