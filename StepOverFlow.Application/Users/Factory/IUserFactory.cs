using StepOverFlow.Application.Users.Commands;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Users.Factory
{
    public interface IUserFactory
    {
        AppUser Create(CreateUserModel model);
    }
}
