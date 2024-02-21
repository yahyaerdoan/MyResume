using MyResume.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyResume.Context
{
    public class DbResumeContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Award> Awards { get; set; }
    }
}