using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Repositories
{
    interface  IEmp_OtherParticularDetails
    {
        int ADDOtherParticularDetails(EmpOtherparticularDetails OPD);
        int UpdateOtherParticularDetails(EmpOtherparticularDetails OPD);
        int DeleteOtherParticularDetails(EmpOtherparticularDetails OPD);
        DataSet GetALLOtherParticularDetails(EmpOtherparticularDetails OPD);
        DataSet GetAllEmpID();
        DataSet GetAllRefEmpIds();

    }
}