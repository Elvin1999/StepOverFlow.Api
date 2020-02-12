using StepOverFlow.Domain.Answers;
using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Posts;
using StepOverFlow.Domain.Questions;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Comments
{
   public class Comment: Entity<int>
    {
        public string Description { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int? AnswerId { get; set; }
        public virtual Answer Answer { get; set; }
        public int? PostId { get; set; }
        public virtual Post Post { get; set; }
        public int? QuestionId { get; set; }
        public virtual Question Question { get; set; }


    }
}
