using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Posts;
using StepOverFlow.Domain.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Skills
{
    public class Skill : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Question> Questions { get; set; }

    }
}
