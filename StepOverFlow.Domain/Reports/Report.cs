﻿using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Reports
{
    public class Report : Entity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

    }
}
