
using Microsoft.AspNetCore.Identity;
using StepOverFlow.Domain.Answers;
using StepOverFlow.Domain.Comments;
using StepOverFlow.Domain.Events;
using StepOverFlow.Domain.EventUsers;
using StepOverFlow.Domain.Likes;
using StepOverFlow.Domain.Messages;
using StepOverFlow.Domain.Notifications;
using StepOverFlow.Domain.Posts;
using StepOverFlow.Domain.Questions;
using StepOverFlow.Domain.Reports;
using StepOverFlow.Domain.Specialities;
using StepOverFlow.Domain.UserTeams;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StepOverFlow.Domain.Users
{
    public class AppUser : IdentityUser<int>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public bool IsProfessional { get; set; }
        public bool IsOnline { get; set; }
        public string ConnectionId { get; set; }
        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }
        public int SpecialityId { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Question> Questions { get; set; }
        public virtual List<Answer> Answers { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Event> Events { get; set; }
        public virtual List<EventUser> EventUsers { get; set; }
        public virtual List<Like> Likes { get; set; }
        public virtual List<Message> Messages  { get; set; }
        public virtual List<UserTeam> UserTeams { get; set; }
        public virtual List<Notification> Notifications { get; set; }
        public virtual List<News.News> News { get; set; }
        public virtual List<Report> Reports { get; set; }
    }
}
