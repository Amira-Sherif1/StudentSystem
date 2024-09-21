using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    internal class ApplicationDbContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem; Integrated Security=True;TrustServerCertificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            modelBuilder.Entity<Student>().
                Property(e => e.PhoneNumber)
                .HasColumnType("varchar(10)");

            modelBuilder.Entity<Student>().
               Property(e => e.RegisteredOn)
               .HasColumnType("datetime");

            modelBuilder.Entity<Student>().
              Property(e => e.Birthday)
              .HasColumnType("datetime");

            modelBuilder.Entity<Homework>()
                .Property(e=> e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
               .Property(e => e.Name)
               .IsUnicode(true)
               .HasMaxLength(80);

            modelBuilder.Entity<Course>()
               .Property(e => e.StartDate)
               .HasColumnType("datetime");

            modelBuilder.Entity<Course>()
              .Property(e => e.EndDate)
              .HasColumnType("datetime");

            modelBuilder.Entity<Resource>()
            .Property(e => e.Name)
            .IsUnicode(true)
            .HasMaxLength(50);


            modelBuilder.Entity<Resource>()
           .Property(e => e.Url)
           .IsUnicode(false);

            modelBuilder.Entity<Resource>()              // I search for it 
                .Property(e => e.ResourceType)
                .HasConversion(e => e.ToString(),
                e => (ResourceType)Enum.Parse(typeof(ResourceType), e));  


            modelBuilder.Entity<Homework>()
                .Property(e => e.ContentType)
                .HasConversion (e => e.ToString(), e=>(ContentType)Enum.Parse(typeof(ContentType),e));

            modelBuilder.Entity<StudentCourse>()
                .HasKey(e => new { e.StudentId, e.CourseId });
                              
        }

    }
}
