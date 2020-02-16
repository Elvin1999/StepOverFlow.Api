using StepOverFlow.Domain.Answers;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Questions.Queries.GetQuestionDetail
{
    public class QuestionDetailItemModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string AppUserId { get; set; }
        public string UserName { get; set; }
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int SpecialtiyId { get; set; }
        public string SpecialityName { get; set; }
        public List<AnswerViewModel> Answers { get; set; }
        public List<CommentViewModel> Comments { get; set; }
    }
}
