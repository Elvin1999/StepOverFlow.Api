using StepOverFlow.Application.Interfaces;
using StepOverFlow.Application.Questions.Commands;
using StepOverFlow.Domain.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepOverFlow.Application.Questions.Factory
{
    public class QuestionFactory : IQuestionFactory
    {
        private IDatabaseService databaseService;

        public QuestionFactory(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        public Question Create(CreateQuestionModel model)
        {
            var skill = databaseService.Skills
                .FirstOrDefault(i => i.Id == model.SkillId);

            var speciality = databaseService.Specialities.FirstOrDefault(i => i.Id == model.SpecialityId);
            var question = new Question
            {
                CreatedAt = DateTimeOffset.Now,
                Description = model.Description,
                Title = model.Title,
                SkillId = model.SkillId,
                SpecialityId = model.SpecialityId,
                Speciality = speciality,
                Skill = skill
            };
            return question;
        }
    }
}
