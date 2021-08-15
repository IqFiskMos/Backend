using EFW_Assignment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFW_Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFW_Assignment;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Teachers)
                .WithOne(t => t.Course)
                .HasForeignKey(t => t.CourseId);

            //modelBuilder.Entity<Teacher>()
            //    .HasMany(c => c.Courses)
            //    .WithOne(t => t.Teacher)
            //    .HasForeignKey(t => t.TeacherId);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Assignments)
                .WithOne(t => t.Course)
                .HasForeignKey(t => t.CourseId);

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "John", LastName = "Johnson", Qualification = "Masters", City = "Mälmo" },
                new Student { StudentId = 2, FirstName = "Alexa", LastName = "Adresson", Qualification = "Diploma", City = "Stockholm" });
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherId = 1, Name = "Jorgon", CourseId = 1 },
                new Teacher { TeacherId = 2, Name = "Ron", CourseId = 2 });
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, CourseName = ".NET", TimePeriod = "8 Months" },
                new Course { CourseId = 2, CourseName = "Java", TimePeriod = "8 Months" });
            modelBuilder.Entity<Assignment>().HasData(
                new Assignment { AssignmentId = 1, Name = ".NET", CourseId = 1 },
                new Assignment { AssignmentId = 2, Name = "Java", CourseId = 2 });
            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentId = 1, CourseId = 1 },
                new StudentCourse { StudentId = 2, CourseId = 2 });
        }
        public DbSet<EFW_Assignment.Models.StudentCourseViewModel> StudentCourseViewModels { get; set; }
    }
}
