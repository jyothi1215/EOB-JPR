using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Models
{
    public class EmpSalBreakUpDetails
    {
        public int SBDID { get; set; }
        public int EmployeeID { get; set; }
        public string ParticularName { get; set; }

        public int ParticularAmount { get; set; }

    }
}