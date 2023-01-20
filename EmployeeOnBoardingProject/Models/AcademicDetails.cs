using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Models
{
    public class AcademicDetails
    {
        public int AcademicDetailsID { get; set; }
        public int EmployeeID { get; set; }

        public string Qualification { get; set; }

        public int UniversityID { get; set; }
        public int CollegeID { get; set; }
        public  DateTime Year { get; set; }
        public Decimal Percentage { get; set; }
    }

}