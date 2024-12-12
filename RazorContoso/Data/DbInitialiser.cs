
using RazorContoso.Data;
using RazorContoso.Models;
using System;
using System.Linq;

namespace RazorContoso.Data
{
    public static class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Amar",LastName="Mohamed",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="White Boy",LastName="Juster",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Man Like",LastName="Mohammed",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="hAkEL",LastName="Khan",EnrollmentDate=DateTime.Parse("2020-09-01")},
                new Student{FirstName="Vincent",LastName="Good Yute",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Timothy",LastName="Arole",EnrollmentDate=DateTime.Parse("2019-09-01")},
               
               
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Web App",Credits=3},
                new Course{CourseID=4022,Title="OOPD",Credits=3},
                new Course{CourseID=4041,Title="Wep Development",Credits=3},
                new Course{CourseID=1045,Title="Python",Credits=4},
                new Course{CourseID=3141,Title="Database Design",Credits=4},
                new Course{CourseID=2021,Title="Appliction Programming",Credits=3},
                new Course{CourseID=2042,Title="Comper Architechture",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}