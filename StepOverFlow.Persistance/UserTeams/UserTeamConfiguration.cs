using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StepOverFlow.Domain.UserTeams;
using System;
namespace StepOverFlow.Persistance.UserTeams
{
    public class UserTeamConfiguration : IEntityTypeConfiguration<UserTeam>
    {
        public void Configure(EntityTypeBuilder<UserTeam> builder)
        {
            builder.HasKey(ps => new { ps.AppUserId, ps.TeamId });


            builder.HasOne(ps => ps.AppUser)
                .WithMany(ps => ps.UserTeams)
                .HasForeignKey(ps => ps.AppUserId);

            builder.HasOne(ps => ps.Team)
                .WithMany(ps => ps.UserTeams)
                .HasForeignKey(ps => ps.TeamId);
        }
    }
}
