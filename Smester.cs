using System.Collections.Generic;
using ManagementStructure.Enums;
using ManagementStructure.Models;

namespace ManagementStructure.Models
{
    public class Smester
    {
        public int Id { get; set; }
        public SmesterType SmesterType { get; set; }
        public int creditHour { get; set; }
        public List<Course> Courses { get; set; }
        public decimal CalculateSGPA()
        {
            var sgpa = Courses.Average(x => (decimal)x.Grade);
            return sgpa;
        }
       

    }
}
