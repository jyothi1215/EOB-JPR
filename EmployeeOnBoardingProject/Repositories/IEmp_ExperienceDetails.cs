using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Repositories
{
    interface IEmp_ExperienceDetails
    {
        int ADDEmpExperienceDetails(ExperienceDetails Exd);
        //int UpdateEmpExperienceDetails(ExperienceDetails Exd);
        //int DeleteEmpExperienceDetails(ExperienceDetails Exd);
        DataSet GetAllEmpID();
        DataSet GetAllEmpExperienceDetails(ExperienceDetails Exd);
    }

}