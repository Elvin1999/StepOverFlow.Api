using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Users.Queries.GetUserDetails
{
    public class UserDetailsItemModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
        public int? GroupId { get; set; }
        public string SpecialityName { get; set; }
        public int SpecialityId { get; set; }
        public List<PostModel> Posts { get; set; }
        public List<EventModel> Events { get; set; }
        public List<QuestionModel> Questions { get; set; }
        public List<RaporModel> Raports { get; set; }
    }
}
