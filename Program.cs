
using System.Security.Cryptography.X509Certificates;
using UniversityManagement.Enums;
using UniversityMangement.Models;


namespace UniversityManagement.Models
{
    public class Program
    {

        /*Student student = new Student
            {
                Name = "Zohaib",
                Address = "Gujranwala",
                Email = " Zohaib@gmail.com",
                PhoneNumber = "1234567890",
                Gender = Enums.Gender.Male,
                StudentID = 1,
                Department=Enums.Department.ComputerScience,
                Batch = new DateOnly(2018, 12, 1),
                WarningCount = 0,
                isLagecy = false,
                EarnedCreditHour = 0,
                Smesters = new List<Smester>
                {
                    new Smester
                    {

                    }
                }
            };
*/
        public static void Main(string[] args)
        {

            Student student = new Student
            {
                Name = "Zohaib",
                Address = "Gujranwala",
                Email = " Zohaib@gmail.com",
                PhoneNumber = "1234567890",
                Gender = Enums.Gender.Male,
                StudentID = 1,
                Department = Enums.Department.ComputerScience,
                Batch = new DateOnly(2018, 12, 1),
                WarningCount = 0,
                isLagecy = false,
                EarnedCreditHour = 0,

            };
            // student.CalculateCGPA();
            Smester obj = new Smester();
            obj.CalculateSGPA();
            
           
            //Console.WriteLine(student.DegreeYear());
            List<Course> courses = Course.GetAllAvailableCourses();
            foreach (var item in courses)
            {
                Console.WriteLine("CourseName :" +  item.CourseName);
                Console.WriteLine("CourseId :" +  item.CourseId);
                Console.WriteLine("CreditHour :" + item.CreditHour);
                Console.WriteLine("Grade :" + item.Grade);
                Console.WriteLine("CourseType :" + item.CourseType);

                Console.WriteLine("-----------------------");
            }

            List<Course> course1 = Course.GetElectiveCourses();
            foreach (var items in course1)
            {
                Console.WriteLine(" CourseType:"+items.CourseName);
                
            }
            int sem = 3;
            List<Course> course2 = Course.GetSmesterCourses(sem);
            foreach (var items in course2) {
                Console.WriteLine(items.CourseName);
            }

            List<Course> course3 = Course.GetDepartmentCourses(Department.Humanities);
            foreach (var item in course2)
            {
                Console.WriteLine(item.CourseName);
            }

        }
    }
}