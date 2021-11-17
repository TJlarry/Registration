using CourseRegistration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op)
        { }
            public DbSet<Course> Courses { get; set; }
            public DbSet<Instructor> Instructors { get; set; }
            public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>().HasData(
            new Course { C_courseID = 1, C_courseNumber = "64745", C_courseName = "Database", C_courseDescription = " DataBase management for beginners" },
            new Course { C_courseID = 2, C_courseNumber = "64746", C_courseName = "Java Programming", C_courseDescription = "Intoduction to Object Oreineted Programming " },
            new Course { C_courseID = 3, C_courseNumber = "64747", C_courseName = "C# programming", C_courseDescription = "Introduction to .NET in C# programming" },
            new Course { C_courseID = 4, C_courseNumber = "64748", C_courseName = "Basic IT", C_courseDescription = " Basic course on Information Tectnology" },
            new Course { C_courseID = 5, C_courseNumber = "64749", C_courseName = "Software Testing", C_courseDescription = "Basic software testing tool for beginners" },
            new Course { C_courseID = 6, C_courseNumber = "64750", C_courseName = " HTML5",           C_courseDescription = "HTML5 for begginners" }
           );
            modelBuilder.Entity<Instructor>().HasData(
            new Instructor { I_instructorID = "7773", I_firstName = "James", I_lastName = "Bonjo", I_emailAddress = "james.B@gmail.com", C_courseID = 001 },
            new Instructor { I_instructorID = "7734", I_firstName = "John", I_lastName = "Prince", I_emailAddress = "john.P@gmail.com", C_courseID = 002 },
            new Instructor { I_instructorID = "7373", I_firstName = "Beth", I_lastName = "Brand", I_emailAddress = "beth.B@gmail.com", C_courseID = 003 },
            new Instructor { I_instructorID = "7883", I_firstName = "Mark", I_lastName = "Zoe", I_emailAddress = "Mark.z@gmail.com", C_courseID = 004 },
            new Instructor { I_instructorID = "7353", I_firstName = "Zion", I_lastName = "Cain", I_emailAddress = "ZionC@gmail.com", C_courseID = 005 },
            new Instructor { I_instructorID = "7233", I_firstName = "Heather", I_lastName = "Yari", I_emailAddress = "HeatherY@gmail.com", C_courseID = 006 }
                );
            modelBuilder.Entity<Student>().HasData(
            new Student { S_studentId = 5634, S_firstName = "Bass", S_lastName = "Cuppy", S_EmailAddress = "Bass.Cuppy@gmail.com", S_phoneNumber = "20497845755" },
            new Student { S_studentId = 6790, S_firstName = "Peter", S_lastName = "Jones", S_EmailAddress = "Peter.Jones@gmail.com", S_phoneNumber = "63669036034" },
            new Student { S_studentId = 3578, S_firstName = "Tayo", S_lastName = "Gbemi", S_EmailAddress = "Tayo.Gbemi@gmail.com", S_phoneNumber = "64758502002" },
            new Student { S_studentId = 5989, S_firstName = "Brandy", S_lastName = "Brown", S_EmailAddress = "Brandy.Brown@gmail.com", S_phoneNumber = "67973752652" },
            new Student { S_studentId = 0124, S_firstName = "kolo", S_lastName = "Beny", S_EmailAddress = "KoloBenny@gmail.com", S_phoneNumber = "08598658635" },
            new Student { S_studentId = 6667, S_firstName = "Temi", S_lastName = "Reed", S_EmailAddress = "temiReed@gmail.com", S_phoneNumber = "08552785953" }




                );




        }        
    }
}
