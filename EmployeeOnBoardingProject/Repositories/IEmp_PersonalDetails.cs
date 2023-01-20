using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Repositories
{
    interface IEmp_PersonalDetails
    {
        int InsertEmployeeDetails(EmployeeDetails Ed);
        DataSet GetAllEmployeeDetails(EmployeeDetails Ed);
        int UpdatePersonalDetails(EmployeeDetails Ed);
        int DeleteEmpDetails(EmployeeDetails Ed);
    }
}

    
