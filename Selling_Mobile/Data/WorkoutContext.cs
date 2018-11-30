﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Selling_Mobile.Models
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext (DbContextOptions<WorkoutContext> options)
            : base(options)
        {
        }

        public DbSet<Selling_Mobile.Models.Workout> Workout { get; set; }
    }
}
