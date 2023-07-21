using FluentValidationDemos.Users.AddUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationDemos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly MediatR.IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public Task<AddUserViewModel> Post([FromBody] AddUserCommand command)
        {
            return _mediator.Send(command);
        }
    }
}