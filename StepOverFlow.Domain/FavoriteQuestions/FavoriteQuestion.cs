using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Questions;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.FavoriteQuestions
{
    public class FavoriteQuestion : Entity<int>
    {
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
