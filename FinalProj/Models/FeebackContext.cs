using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProj.Models
{
    public class FeedbackContext : IdentityDbContext<ApplicationUser>
    {
        public FeedbackContext(DbContextOptions<FeedbackContext> options)
        : base(options)
        { }

        public DbSet<Feedback> Feedbacks { get; set; }

    }

}