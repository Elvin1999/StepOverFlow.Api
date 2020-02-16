using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Users.Commands
{
    public class CreateUserModel
    {
        public string Id { get; set; }
        public bool IsOnline { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }
        public int SpecialityId { get; set; }
        public bool IsProffesional { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }

    }
}
