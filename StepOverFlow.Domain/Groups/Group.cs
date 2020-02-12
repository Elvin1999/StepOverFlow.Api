using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Specialities;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Groups
{
    public class Group : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<AppUser> AppUsers { get; set; }
        public int SpecialtyId { get; set; }
        public virtual Speciality Speciality { get; set; }
    }
}
