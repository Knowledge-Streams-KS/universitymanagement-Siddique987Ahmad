using System.Collections.Generic;
using UniversityManagement.Models;
using UniversityManagement.Enums;
//using UniversityManagement.Enums;
using UniversityManagement.Enums;

namespace UniversityManagement.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int SemId { get; set; }
        public string CourseName { get; set; }
        public int CreditHour { get; set; }
        public CourseType CourseType { get; set; }
        public Faculty Instructor { get; set; }
        public Grade Grade { get; set; }
        public Department Department { get; set; }

        public static List<Course> GetAllAvailableCourses()
        {
            List<Course> Courses = new List<Course>();
            Course PF = new Course
            {
                CourseId = 001,
                SemId = 1,
                CourseName = "Programming Fundamentals",
                CourseType = UniversityManagement.Enums.CourseType.Core,
                CreditHour = 3,
                Grade = UniversityManagement.Enums.Grade.un,
                Department = UniversityManagement.Enums.Department.ComputerScience,
                Instructor = new Faculty()
            };

            Course DS = new Course
            {
                CourseId = 002,
                SemId = 2,
                CourseName = "Data Structures",
                CourseType = UniversityManagement.Enums.CourseType.Core,
                CreditHour = 4,
                Grade = UniversityManagement.Enums.Grade.un,
                Department = UniversityManagement.Enums.Department.ComputerScience,
                Instructor = new Faculty()

            };

            Course English = new Course
            {
                CourseId = 003,
                SemId = 1,
                CourseName = "English",
                CourseType = UniversityManagement.Enums.CourseType.Core,
                CreditHour = 3,
                Grade = UniversityManagement.Enums.Grade.un,
                Department = UniversityManagement.Enums.Department.Humanities,
                Instructor = new Faculty()
            };

            Course PakStudies = new Course
            {
                CourseId = 004,
                SemId = 1,
                CourseName = "Pakistan Studies",
                CourseType = UniversityManagement.Enums.CourseType.Core,
                CreditHour = 2,
                Grade = UniversityManagement.Enums.Grade.un,
                Department = UniversityManagement.Enums.Department.Humanities,
                Instructor = new Faculty()
            };

            Course ITC = new Course
            {
                CourseId = 005,
                SemId = 1,
                CourseName = "Introduction to Computing",
                CourseType = UniversityManagement.Enums.CourseType.Core,
                CreditHour = 3,
                Grade = UniversityManagement.Enums.Grade.un,
                Department = UniversityManagement.Enums.Department.ComputerScience,
                Instructor = new Faculty()
            };

            Course Islamiat = new Course
            {
                CourseId = 006,
                SemId = 2,
                CourseName = "Islamiat",
                CourseType = UniversityManagement.Enums.CourseType.Core,
                CreditHour = 3,
                Grade = UniversityManagement.Enums.Grade.un,
                Department = UniversityManagement.Enums.Department.Humanities,
                Instructor = new Faculty()
            };

            Course Databases = new Course
            {
                CourseId = 007,
                SemId = 3,
                CourseName = "Databases",
                CourseType = UniversityManagement.Enums.CourseType.Core,
                CreditHour = 4,
                Grade = UniversityManagement.Enums.Grade.un,
                Department = UniversityManagement.Enums.Department.ComputerScience,
                Instructor = new Faculty()
            };

            Course OB = new Course
            {
                CourseId = 008,
                SemId = 0,
                CourseName = "Organizational Behavior",
                CourseType = UniversityManagement.Enums.CourseType.Elective,
                CreditHour = 3,
                Grade = UniversityManagement.Enums.Grade.un,
                Department = UniversityManagement.Enums.Department.ManagementScience,
                Instructor = new Faculty()
            };

            Course ITL = new Course
            {
                CourseId = 009,
                SemId = 0,
                CourseName = "Intro to Law",
                CourseType = UniversityManagement.Enums.CourseType.Elective,
                CreditHour = 3,
                Grade = UniversityManagement.Enums.Grade.un,
                Department = UniversityManagement.Enums.Department.Law,
                Instructor = new Faculty()
            };

            Course CalI = new Course
            {
                CourseId = 010,
                SemId = 1,
                CourseName = "Calculus I",
                CourseType = UniversityManagement.Enums.CourseType.Core,
                CreditHour = 3,
                Grade = UniversityManagement.Enums.Grade.un,
                Department = UniversityManagement.Enums.Department.ComputerScience,
                Instructor = new Faculty()
            };

            Courses.Add(PF);
            Courses.Add(DS);
            Courses.Add(English);
            Courses.Add(ITL);
            Courses.Add(OB);
            Courses.Add(Databases);
            Courses.Add(ITC);
            Courses.Add(Islamiat);
            Courses.Add(PakStudies);
            Courses.Add(CalI);

            return Courses;
        }
        public static List<Course> GetSmesterCourses(int SmesterId)
        {
            return Course.GetAllAvailableCourses().Where(x => x.SemId == SmesterId).ToList();
        }
        public static List<Course> GetElectiveCourses()
        {
            return Course.GetAllAvailableCourses().Where(x => x.CourseType == CourseType.Elective).ToList();

        }
        public static List<Course> GetDepartmentCourses(Department department)
        {
            return Course.GetAllAvailableCourses().Where(x => x.Department == department).ToList();
        }

    }
}
