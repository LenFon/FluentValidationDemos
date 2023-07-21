using System.Threading;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationDemos.Users.AddUser
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, AddUserViewModel>
    {
        public AddUserCommandHandler()
        {
        }

        public async Task<AddUserViewModel> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
			throw new NotImplementedException();
        }
    }
}
