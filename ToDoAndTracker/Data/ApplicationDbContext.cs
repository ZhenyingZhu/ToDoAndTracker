using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoAndTracker.Models;

namespace ToDoAndTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<ProjectNote> ProjectNotes { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProjectTag> ProjectTags { get; set; }

        public DbSet<Diary> Diaries { get; set; }
        public DbSet<Takeaway> Takeaways { get; set; }
        public DbSet<DiaryTakeaway> DiaryTakeaways { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Project>().ToTable("Project");
            builder.Entity<Task>().ToTable("Task");
            builder.Entity<Event>().ToTable("Event");

            builder.Entity<ProjectNote>().ToTable("ProjectNote");

            builder.Entity<Tag>().ToTable("Tag");
            builder.Entity<ProjectTag>().ToTable("ProjectTag");
            builder.Entity<ProjectTag>().HasKey(pt => new { pt.ProjectId, pt.TagId });

            builder.Entity<Diary>().ToTable("Diary");
            builder.Entity<Takeaway>().ToTable("Takeaway");
            builder.Entity<DiaryTakeaway>().ToTable("DiaryTakeaway");
            builder.Entity<DiaryTakeaway>().HasKey(dt => new { dt.DiaryId, dt.TakeawayId });
        }
    }
}
