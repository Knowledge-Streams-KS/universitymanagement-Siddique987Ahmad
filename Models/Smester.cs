using System.Collections.Generic;
using UniversityManagement.Enums;
using UniversityManagement.Models;

namespace UniversityMangement.Models
{
    public class Smester
    {
        public int Id { get; set; }
        public SmesterType SmesterType { get; set; }
        public string creditHour { get; set; }
        public List<Course> Courses { get; set; }
        public decimal CalculateSGPA()
        {
            var sgpa=Courses.Average(x => (decimal)x.Grade); 
            return sgpa;
        }
        public static List<Smester> RegisterSmester(SmesterType type)
        {
            return new List<Smester>();
        }
       
    }
}
