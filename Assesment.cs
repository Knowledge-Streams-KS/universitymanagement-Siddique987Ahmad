using System.Collections.Generic;
using ManagementStructure.Enums;
//using UniversityManagement.Enums;
using ManagementStructure.Enums;
using System.Diagnostics;
using ManagementStructure.Models;

namespace ManagementStructure.Models
{
    public class Assesment
    {
        public int AssesmentID { get; set; }
        public String AssesmentName { get; set; }
        public Assesmenttype assesmenttype  { get; set; }
        public double TotalMarks { get; set; }
        public double ObtainedMarks { get; set; }
        public double Weightage { get; set; }
        
        public Assesment() { }
      public  Assesment(int AssesmentID,string AssesmentName,Assesmenttype assesmenttype,double TotalMarks,double ObtainedMarks,double Weightage) 
        {
            this.AssesmentID = AssesmentID;
            this.AssesmentName = AssesmentName;
            this.Weightage = Weightage;
            this.TotalMarks = TotalMarks;
            this.ObtainedMarks = ObtainedMarks;
            this.assesmenttype = assesmenttype;
        }
        public double GetAbsoluteMarks()
        {
            return (ObtainedMarks / TotalMarks) * Weightage;
        }
           

    }
}
