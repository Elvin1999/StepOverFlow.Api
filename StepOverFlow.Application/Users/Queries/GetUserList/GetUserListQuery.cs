using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StepOverFlow.Application.Interfaces;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepOverFlow.Application.Users.Queries
{
    public class GetUserListQuery : IGetUserListQuery
    {
        private IDatabaseService databaseService;
        private readonly UserManager<AppUser> userManager;

        public GetUserListQuery(IDatabaseService databaseService,
            UserManager<AppUser> userManager)
        {
            this.databaseService = databaseService;
            this.userManager = userManager;
        }

        public List<UserListItemModel> Execute()
        {
            var users = userManager.Users
                .Include(i => i.Group)
                .Include(i=>i.Speciality)
                .Select(i => new UserListItemModel
                {
                    Id = i.Id,
                    UserName = i.UserName,
                    FirstName = i.Firstname,
                    LastName = i.Lastname,
                    GroupName = i.Group.Name,
                    SpecialityName = i.Speciality.Name,
                    TelNumber = i.PhoneNumber
                }).ToList();

            return users;
        }
    }
}
