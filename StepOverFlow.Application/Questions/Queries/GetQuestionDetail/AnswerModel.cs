using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Questions.Queries.GetQuestionDetail
{
    public class AnswerModel
    {
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }

    }
}
