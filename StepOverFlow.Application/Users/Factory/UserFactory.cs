using StepOverFlow.Application.Interfaces;
using StepOverFlow.Application.Users.Commands;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepOverFlow.Application.Users.Factory
{
    public class UserFactory : IUserFactory
    {
        private IDatabaseService databaseService;

        public UserFactory(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        public AppUser Create(CreateUserModel model)
        {
            var group = databaseService.Groups
                .FirstOrDefault(i => i.Id == model.GroupId);
            var speciality = databaseService.Specialities
                .FirstOrDefault(i => i.Id == model.SpecialityId);

            var user = new AppUser()
            {
                Id=model.Id,
                IsOnline=model.IsOnline,
                DateOfBirth=model.DateOfBirth,
                UserName=model.UserName,
                Firstname=model.FirstName,
                Lastname=model.LastName,
                GroupId=model.GroupId,
                Group = group,
                Speciality=speciality,
                SpecialityId=model.SpecialityId        
            };
            return user;
        }
    }
}
