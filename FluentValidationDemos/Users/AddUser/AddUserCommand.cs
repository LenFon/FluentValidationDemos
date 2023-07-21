using MediatR;

namespace FluentValidationDemos.Users.AddUser;

public class AddUserCommand : IRequest<AddUserViewModel>
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public int Age { get; set; }
}
