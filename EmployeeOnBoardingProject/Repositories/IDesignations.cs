using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Repositories
{
    interface IDesignations
    {
        DataSet GetDesignationsDetails();
        DataSet GetDesignationsDetailsbyID(Designations Dd);

    }
}