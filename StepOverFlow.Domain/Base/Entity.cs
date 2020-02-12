using System;
using System.Collections.Generic;
using System.Text;
namespace StepOverFlow.Domain.Base
{
   public class Entity<Tid>
    {
        public Tid Id { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}