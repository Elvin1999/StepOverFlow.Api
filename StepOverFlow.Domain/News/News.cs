using StepOverFlow.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.News
{
    public class News : Entity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
