using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Users.Queries
{
    public interface IGetUserListQuery
    {
        List<UserListItemModel> Execute();
    }
}
