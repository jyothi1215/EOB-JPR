using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Repositories
{
    interface IColonies
    {
        DataSet GetAllColonies(int CityID);

    }
}