using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Comments;
using StepOverFlow.Domain.Likes;
using StepOverFlow.Domain.Skills;
using StepOverFlow.Domain.Specialities;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
namespace StepOverFlow.Domain.Posts
{
    public class Post : Entity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int SeenCount { get; set; }
        public bool IsPublic { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int SkillId { get; set; }
        public virtual Skill Skill { get; set; }
        public int SpecialityId { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Like> Likes { get; set; }
    }
}
