using JobPortal_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobPortal_API.ApplicationDbContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("JobPortal")
        {
            
        }
       public  DbSet<Registration> RegistrationsTable { get; set; }
        public DbSet<UserDetails> UserDetailsTable { get; set; }
        public DbSet<JobDetails> JobDetailsTable { get; set; }
    }
}