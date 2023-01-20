using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Models
{
    public class ExperienceDetails
    {
        public int ExperienceDetailsID { get; set; }
        public int EmployeeID { get; set; }
        public string Organization { get; set; }
        public int  DesignationID { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string SkillID { get; set; }

    }
} 