using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Repositories
{
    interface IEmp_AcademicDetails
    {
        DataSet GetAllEmpAcademicDetails(AcademicDetails Ad);
        int ADD_EmpAcademicDetails(AcademicDetails Ad);
        DataSet GetAllEmpID();
        int Update_EmpAcademicDetails(AcademicDetails Ad);
        int DeleteEmpDetails(AcademicDetails Ad);

    }
}