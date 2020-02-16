using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StepOverFlow.Application.Interfaces;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepOverFlow.Application.Users.Queries.GetUserDetails
{
    public class GetUserDetailsQuery : IGetUserDetailsQuery
    {
        private IDatabaseService databaseService;
        private readonly UserManager<AppUser> userManager;

        public GetUserDetailsQuery(IDatabaseService databaseService,
            UserManager<AppUser> userManager)
        {
            this.databaseService = databaseService;
            this.userManager = userManager;
        }

        public async Task<UserDetailsItemModel> Execute(string userId)
        {
            //var user = await userManager.FindByIdAsync(userId);
            //UserDetailsItemModel userModel = new UserDetailsItemModel
            //{
            //    Id = user.Id,
            //    FirstName = user.Firstname,
            //    LastName = user.Lastname,
            //    Events = user.Events.Select(i => new EventModel
            //    {
            //        Id = i.Id,
            //        Name = i.Name,
            //        Description = i.Description,
            //        EventTime = i.EventTime,
            //        Location = i.Location
            //    }).ToList(),
            //    GroupId = user.GroupId,
            //    GroupName = user.Group.Name,
            //    Posts = user.Posts.Select(i => new PostModel
            //    {
            //        Description = i.Description,
            //        Id = i.Id,
            //        Title = i.Title

            //    }).ToList(),
            //    Questions = user.Questions.Select(i => new QuestionModel
            //    {
            //        Id = i.Id,
            //        Description = i.Description,
            //        Rating = i.Rating,
            //        Title = i.Title
            //    }).ToList(),
            //    SpecialityId = user.SpecialityId,
            //    SpecialityName = user.Speciality.Name,
            //    UserName = user.UserName,
            //    Raports = user.Reports.Select(i => new RaporModel
            //    {
            //        Description=i.Description,
            //        Id=i.Id,
            //        Title=i.Title
            //    }).ToList()
            //};
            var users = userManager.Users;
            var userModel = await users.Include(i => i.Group)
                .Include(i => i.Speciality)
                .Where(i => i.Id == userId)
                .Select(i => new UserDetailsItemModel
                {
                    Id = i.Id,
                    GroupId = i.GroupId,
                    SpecialityId = i.SpecialityId,
                    FirstName = i.Firstname,
                    LastName = i.Lastname,
                    GroupName = i.Group.Name,
                    SpecialityName = i.Speciality.Name,
                    UserName = i.UserName,
                    Posts = i.Posts.Select(p => new PostModel
                    {
                        Id = p.Id,
                        Description = p.Description,
                        Title = p.Title
                    }).ToList(),
                    Events = i.Events.Select(e => new EventModel
                    {
                        Id = e.Id,
                        Name = e.Name,
                        EventTime = e.EventTime,
                        Description = e.Description,
                        Location = e.Location
                    }).ToList(),
                    Questions = i.Questions.Select(q => new QuestionModel
                    {
                        Id = q.Id,
                        Title = q.Title,
                        Description = q.Description,
                        Rating = q.Rating
                    }).ToList(),
                    Raports = i.Reports.Select(r => new RaporModel
                    {
                        Id = r.Id,
                        Description = r.Description,
                        Title = r.Title
                    }).ToList()

                }).FirstOrDefaultAsync();

            return userModel;
        }
    }
}
