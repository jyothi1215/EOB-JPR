using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Models
{
    public class EmpOtherparticularDetails
    {
        public int OPDID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime EarliestDOJ { get; set; }
        public int CurrentSalary { get; set; }

        public int ReferenceEmployeeID { get; set; }
    }
}