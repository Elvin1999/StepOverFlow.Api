using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StepOverFlow.Application.Interfaces;
using StepOverFlow.Domain.Answers;
using StepOverFlow.Domain.Comments;
using StepOverFlow.Domain.Events;
using StepOverFlow.Domain.EventUsers;
using StepOverFlow.Domain.FavoritePosts;
using StepOverFlow.Domain.FavoriteQuestions;
using StepOverFlow.Domain.Groups;
using StepOverFlow.Domain.Likes;
using StepOverFlow.Domain.Messages;
using StepOverFlow.Domain.News;
using StepOverFlow.Domain.Notifications;
using StepOverFlow.Domain.Posts;
using StepOverFlow.Domain.Questions;
using StepOverFlow.Domain.Reports;
using StepOverFlow.Domain.Settings;
using StepOverFlow.Domain.Skills;
using StepOverFlow.Domain.Specialities;
using StepOverFlow.Domain.Teams;
using StepOverFlow.Domain.Users;
using StepOverFlow.Domain.UserTeams;
using StepOverFlow.Persistance.UserTeams;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Persistance.DataContexts
{
    public class AppDbContext : IdentityDbContext<AppUser,IdentityRole, string>, IDatabaseService
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<EventUser> EventUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<FavoritePost> FavoritePosts { get; set; }
        public DbSet<FavoriteQuestion> FavoriteQuestions { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }
        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserTeamConfiguration());
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //        .UseSqlServer(
        //        @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        //}
        public void Save()
        {
            this.SaveChanges();
        }
    }
}
