using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Repositories
{
    interface IEmp_SalaryBreakUpDetails
    {
       int  ADDSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd);
        int UpdateSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd);
        int DeleteSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd);
        DataSet GetAllSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd);

        DataSet GetAllEmpID();
    }
}