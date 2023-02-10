using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;
using ManagementStructure.Enums;
using ManagementStructure.Models;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics.Metrics;

namespace ManagementStructure.Models
{
    public class Student : person
    {
        public int StudentID { get; set; }
        public Department Department { get; set; }

        public DateOnly Batch { get; set; }
        public int WarningCount { get; set; }
        public bool isLagecy { get; set; }
        public int EarnedCreditHour { get; set; }
        public float CGPA { get; set; }
        public int courses { get; set; }
        public List<Smester> Smesters { get; set; }

        public void RegisterSmester(SmesterType type)
        {
            var SmesterID = this.Smesters.Count + 1;
            List<Course> smesterCourse = Course.GetSmesterCourses(SmesterID);
            var credithour = smesterCourse.Sum(x => x.CreditHour);
            Smester smester = new Smester()
            {
                Id= SmesterID,
                Courses= smesterCourse,
                SmesterType=type,
                creditHour=credithour,


            };
            this.Smesters.Add(smester);
        }

        public int DegreeYear()
        {
            var item = DateTime.Now.Year - Batch.Year;

            return item;
        }
        public decimal CalculateCGPA()
        {
            var Cgpa = Smesters.Average(x => x.CalculateSGPA());
            return Cgpa;
        }
        public Smester GetCurrentSemester()
        {
            return Smesters.Last();
        }
    }
}