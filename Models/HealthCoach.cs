﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutSite.Models
{
    public class HealthCoach
    {
        public virtual int HealthCoachId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }
}