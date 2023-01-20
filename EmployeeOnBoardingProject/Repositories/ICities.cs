using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Repositories
{
    interface ICities
    {
        DataSet GetAllCities(int StateID);
    }
}