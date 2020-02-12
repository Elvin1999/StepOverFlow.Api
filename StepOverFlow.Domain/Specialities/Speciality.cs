using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Groups;
using StepOverFlow.Domain.Posts;
using StepOverFlow.Domain.Questions;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Specialities
{
    public class Speciality : Entity<int>
    {
        public string Name { get; set; }
        public virtual List<AppUser> AppUsers { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Question> Questions { get; set; }
        public virtual List<Group> Groups { get; set; }
    }
}
