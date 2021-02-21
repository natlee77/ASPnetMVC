using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RolesAndPolicy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RolesAndPolicy.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<SchoolCourse> SchoolCourses { get; set; }
    }
}
