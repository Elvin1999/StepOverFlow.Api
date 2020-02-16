using System;

namespace StepOverFlow.Application.Users.Queries.GetUserDetails
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTimeOffset EventTime { get; set; }

    }
}