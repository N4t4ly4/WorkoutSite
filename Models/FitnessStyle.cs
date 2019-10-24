using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutSite.Models
{
    public class FitnessStyle
    {
        public virtual int FitnessStyleId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual List<HealthCoach> HealthCoaches { get; set; }

    }
}