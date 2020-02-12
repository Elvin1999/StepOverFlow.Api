using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Comments;
using StepOverFlow.Domain.Questions;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Answers
{
   public class Answer: Entity<int>
    {
        public string Description { get; set; }
        public int Rating { get; set; }
        public bool IsCorrect { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public virtual List<Comment> Comments { get; set; }

    }
}
