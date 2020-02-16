using Microsoft.EntityFrameworkCore;
using StepOverFlow.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepOverFlow.Application.Questions.Queries.GetQuestionDetail
{
    public class GetQuestionDetailQuery : IGetQuestionDetailQuery
    {
        private IDatabaseService databaseService;

        public GetQuestionDetailQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        public QuestionDetailItemModel Execute(int questionId)
        {
            return databaseService.Questions
                .Include(i => i.Skill)
                .Include(i => i.Speciality)
                .Include(i => i.Answers)
                .ThenInclude(i => i.AppUser)
                .Include(i => i.AppUser)
                .Where(i => i.Id == questionId).Select(i => new QuestionDetailItemModel
                {
                    Id = i.Id,
                    Answers = i.Answers.Select(ii => new AnswerViewModel
                    {
                        Id = ii.Id,
                        IsCorrect = ii.IsCorrect,
                        UserId = ii.AppUserId,
                        Description = ii.Description,
                        Rating = ii.Rating,
                        UserName = ii.AppUser.UserName
                    }).ToList(),
                    AppUserId = i.AppUserId,
                    UserName = i.AppUser.UserName,
                    Comments = i.Comments.Select(c => new CommentViewModel
                    {
                        Id = c.Id,
                        UserId = c.AppUserId,
                        Description = c.Description,
                        UserName = c.AppUser.UserName
                    }).ToList(),
                    Description = i.Description,
                    Rating = i.Rating,
                    SkillId = i.SkillId,
                    SkillName = i.Skill.Name,
                    SpecialityName = i.Speciality.Name,
                    SpecialtiyId = i.SpecialityId,
                    Title = i.Title
                }).FirstOrDefault();

        }
    }
}
