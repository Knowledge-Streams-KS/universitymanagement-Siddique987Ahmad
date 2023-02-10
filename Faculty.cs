using ManagementStructure.Enums;
using System.Collections.Generic;

namespace ManagementStructure.Models
{
    public class Faculty:person
    {
        public int FacultyId { get; set; }

        public Department department { get; set; }
        public int Cabin { get; set; }
        public Facultytype facultytype { get; set; }
        public Designation designation { get; set; }
        public int courseId { get; set; }
        public static void AssignGrade(Student obj )
        {
           
        }
        public static List<Assesment> assessmentMarks = new List<Assesment>();
        private static void InitilizeAssesment()
        {
            Assesment quiz = new Assesment
            {
                AssesmentName = "Quiz 1",
                assesmenttype = Assesmenttype.Quiz,
                TotalMarks = 100,
                ObtainedMarks = 61,
            };
            Assesment assignment = new Assesment
            {
                AssesmentName = "Quiz 1",
                assesmenttype = Assesmenttype.Assignment,
                TotalMarks = 100,
                ObtainedMarks = 61,
            };
            Assesment mid = new Assesment
            {


                AssesmentName = "Quiz 1",
                assesmenttype = Assesmenttype.Mid,
                TotalMarks = 100,
                ObtainedMarks = 61,
            };
            Assesment final = new Assesment
            {
                AssesmentName = "Quiz 1",
                assesmenttype = Assesmenttype.Final,
                TotalMarks = 100,
                ObtainedMarks = 61,
            };
        }
       
        public void RegisterCourse(int courseID)
        {
            //var c = Course.GetFacultycourse(courseID);
            //this.courseId = courseID;
            //c.FacultyID = this.FacultyId;
            Course.GetAllAvailableCourses().Find(x => x.CourseId == courseID).Instructor = this.FacultyId;
            this.courseId= courseID;
        }
        public void AddAssesment(List<Student> students, int assesmentID, Assesmenttype assesmentType, string assesmentName, double totalMarks, double weightage)
        {
            //var myStudent = students.Select(student => student.GetCurrentSemester().Courses.Find(CourseId));
            //Assesment assessment = new Assesment(assesmentID, assesmentName, assesmentType, 0, totalMarks);
            //students[0].GetCurrentSemester().Courses[0]..Add(assessment);
            //students[1].GetCurrentSemester().Courses[0].assignments.Add(assessment);
            //students[2].GetCurrentSemester().Courses[0].assignments.Add(assessment);
            var ourCourse = students.Select(students => students.GetCurrentSemester().Courses.Find(x => x.CourseId == this.courseId).CourseId == this.courseId).ToList();
        }

    }
}
