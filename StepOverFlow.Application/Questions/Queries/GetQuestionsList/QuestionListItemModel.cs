using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Questions.Queries.GetQuestionsList
{
    public class QuestionListItemModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string SkillName { get; set; }
        public int SkillId { get; set; }
        public int SpecialityId { get; set; }
        public string SpecialityName { get; set; }
    }
}
