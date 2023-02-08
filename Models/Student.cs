using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;
using UniversityManagement.Enums;
using UniversityManagement.Models;
using System.Threading.Tasks.Dataflow;

namespace UniversityMangement.Models
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

        public List<Smester> Smesters { get;set; }
        public int DegreeYear()
        {
          var item= DateTime.Now.Year - Batch.Year;
         
            return item;
        }
        public decimal CalculateCGPA()
        {
            var Cgpa = Smesters.Average(x => x.CalculateSGPA()); 
            return Cgpa;
        }
    }
}