using Microsoft.EntityFrameworkCore;
using StepOverFlow.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepOverFlow.Application.Questions.Queries.GetQuestionsList
{


    public class GetQuestionsListQuery : IGetQuestionsListQuery
    {
        private readonly IDatabaseService databaseService;

        public GetQuestionsListQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        public List<QuestionListItemModel> Execute()
        {
            return databaseService.Questions
                .Include(i => i.Skill)
                .Select(i => new QuestionListItemModel
                {
                    Id = i.Id,
                    Description = i.Description,
                    Title = i.Title,
                    Rating = i.Rating,
                    SkillId = i.SkillId,
                    SkillName = i.Skill.Name,
                    SpecialityId=i.SpecialityId,
                    SpecialityName=i.Speciality.Name,
                    UserId=i.AppUserId,
                    UserName=i.AppUser.UserName
                }).ToList();
        }
    }
}
