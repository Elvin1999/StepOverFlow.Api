using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StepOverFlow.Application.Users.Commands
{
    public interface ICreateUserCommand
    {
        Task<IdentityResult> Execute(CreateUserModel model);
    }
}
