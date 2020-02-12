using StepOverFlow.Domain.Answers;
using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Comments;
using StepOverFlow.Domain.Posts;
using StepOverFlow.Domain.Skills;
using StepOverFlow.Domain.Specialities;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Questions
{
    public class Question : Entity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Answer> Answers { get; set; }
        public int SkillId { get; set; }
        public virtual Skill Skill { get; set; }
        public int SpecialityId { get; set; }
        public virtual Speciality Speciality { get; set; }
    }
}
