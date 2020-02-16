using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StepOverFlow.Application.Users.Queries.GetUserDetails
{
    public interface IGetUserDetailsQuery
    {
        Task<UserDetailsItemModel> Execute(string userId);
    }
}
