using System.Collections.Generic;
using ManagementStructure.Enums;
//using UniversityManagement.Enums;
using ManagementStructure.Enums;
using System.Diagnostics;
using ManagementStructure.Models;

namespace ManagementStructure.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int SemId { get; set; }
        public string CourseName { get; set; }
        public int CreditHour { get; set; }
        public CourseType CourseType { get; set; }
        public int Instructor { get; set; }
        public Assesment assesment { get; set; }
        public Grade Grade { get; set; }
        public Department Department { get; set; }

        public static List<Course> GetAllAvailableCourses()
        {
            List<Course> Courses = new List<Course>();
            if (Courses.Count == 0)
                Initialize();

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

       //public static void AssignmentInitize(int CourseId,Faculty faculty)
       // {
       //     var assign=Courses.Find(x=>x.CourseId == faculty.Name);
       //     Courses.Add(assign);
       // }
       private static void FacultyInitialize()
        {
            Faculty faculty = new Faculty
            {
                Name = "Siddique",
                Address = "RYK",
                Email = "Sidd@ks.com",
                PhoneNumber = "1234567890",
                Gender = Enums.Gender.Male,
                FacultyId = 1,
                department = Enums.Department.ComputerScience,
                facultytype = Enums.Facultytype.Permanent,
                Cabin = 2,
                designation = Enums.Designation.Teacher,

            };
            Faculty HOD = new Faculty
            {
                Name = "Hamza",
                Address = "Lahore",
                Email = "Hmza@ks.com",
                PhoneNumber = "1234567890",
                Gender = Enums.Gender.Male,
                FacultyId = 2,
                department = Enums.Department.ComputerScience,
                facultytype = Enums.Facultytype.Permanent,
                Cabin = 5,
                designation = Enums.Designation.HOD,

            };
            Faculty Associate = new Faculty
            {
                Name = "Moeed",
                Address = "GJW",
                Email = "Moed@ks.com",
                PhoneNumber = "1234567890",
                Gender = Enums.Gender.Male,
                FacultyId = 3,
                department = Enums.Department.ManagementScience,
                facultytype = Enums.Facultytype.Visiting,
                Cabin = 10,
                designation = Enums.Designation.AssociateTeacher,

            };
            Faculty Director = new Faculty
            {
                Name = "Rao",
                Address = "FSD",
                Email = "RAO@ks.com",
                PhoneNumber = "1234567890",
                Gender = Enums.Gender.Male,
                FacultyId = 4,
                department = Enums.Department.Humanities,
                facultytype = Enums.Facultytype.Permanent,
                Cabin = 14,
                designation = Enums.Designation.Director,

            };
            faculties.Add(Director);
            faculties.Add(faculty);
            faculties.Add(HOD);
            faculties.Add(Associate);
        }
        private static void Initialize()
        {
            Course PF = new Course
            {
                CourseId = 001,
                SemId = 1,
                CourseName = "Programming Fundamentals",
                CourseType = ManagementStructure.Enums.CourseType.Core,
                CreditHour = 3,
                Grade = ManagementStructure.Enums.Grade.un,
                Department = ManagementStructure.Enums.Department.ComputerScience,
              
                
            };

            Course DS = new Course
            {
                CourseId = 002,
                SemId = 2,
                CourseName = "Data Structures",
                CourseType = ManagementStructure.Enums.CourseType.Core,
                CreditHour = 4,
                Grade = ManagementStructure.Enums.Grade.un,
                Department = ManagementStructure.Enums.Department.ComputerScience,

            };

            Course English = new Course
            {
                CourseId = 003,
                SemId = 1,
                CourseName = "English",
                CourseType = ManagementStructure.Enums.CourseType.Core,
                CreditHour = 3,
                Grade = ManagementStructure.Enums.Grade.un,
                Department = ManagementStructure.Enums.Department.Humanities,
            };

            Course PakStudies = new Course
            {
                CourseId = 004,
                SemId = 1,
                CourseName = "Pakistan Studies",
                CourseType = ManagementStructure.Enums.CourseType.Core,
                CreditHour = 2,
                Grade = ManagementStructure.Enums.Grade.un,
                Department = ManagementStructure.Enums.Department.Humanities,
            };

            Course ITC = new Course
            {
                CourseId = 005,
                SemId = 1,
                CourseName = "Introduction to Computing",
                CourseType = ManagementStructure.Enums.CourseType.Core,
                CreditHour = 3,
                Grade = ManagementStructure.Enums.Grade.un,
                Department = ManagementStructure.Enums.Department.ComputerScience,
            };

            Course Islamiat = new Course
            {
                CourseId = 006,
                SemId = 2,
                CourseName = "Islamiat",
                CourseType = ManagementStructure.Enums.CourseType.Core,
                CreditHour = 3,
                Grade = ManagementStructure.Enums.Grade.un,
                Department = ManagementStructure.Enums.Department.Humanities,
            };

            Course Databases = new Course
            {
                CourseId = 007,
                SemId = 3,
                CourseName = "Databases",
                CourseType = ManagementStructure.Enums.CourseType.Core,
                CreditHour = 4,
                Grade = ManagementStructure.Enums.Grade.un,
                Department = ManagementStructure.Enums.Department.ComputerScience,
            };

            Course OB = new Course
            {
                CourseId = 008,
                SemId = 0,
                CourseName = "Organizational Behavior",
                CourseType = ManagementStructure.Enums.CourseType.Elective,
                CreditHour = 3,
                Grade = ManagementStructure.Enums.Grade.un,
                Department = ManagementStructure.Enums.Department.ManagementScience,
            };

            Course ITL = new Course
            {
                CourseId = 009,
                SemId = 0,
                CourseName = "Intro to Law",
                CourseType = ManagementStructure.Enums.CourseType.Elective,
                CreditHour = 3,
                Grade = ManagementStructure.Enums.Grade.un,
                Department = ManagementStructure.Enums.Department.Law,
            };

            Course CalI = new Course
            {
                CourseId = 010,
                SemId = 1,
                CourseName = "Calculus I",
                CourseType = ManagementStructure.Enums.CourseType.Core,
                CreditHour = 3,
                Grade = ManagementStructure.Enums.Grade.un,
                Department = ManagementStructure.Enums.Department.ComputerScience,
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


        }
        private static List<Course> Courses = new List<Course>();
        private static List<Faculty> faculties = new List<Faculty>();
        public static List<Faculty> AllavailableFaculty()
        {
            List<Faculty> facultiesList = new List<Faculty>();
            if (faculties.Count == 0)
                FacultyInitialize();
            return facultiesList;

        }

        public static void AddCourse(Course courses)
        {
            Courses.Add(courses);
        }
        public static void RemoveCourse(int id)
        {
            var a=Courses.Find(x=>x.CourseId==id);
            Courses.Remove(a);
        }
        public static void GetFacultycourse(int courseID)
        {
            //faculties.Add(faculty);
        }

    }
}
