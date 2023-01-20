using EmployeeOnBoardingProject.CommonUtilities;
using EmployeeOnBoardingProject.DataAccessLayer;
using EmployeeOnBoardingProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.BusinessAccessLayer
{
    public class StateBal : IStates
    {
        public DataSet GetAllStates(int CountryID)
        {
            StateDal Dal = new StateDal();
            DataSet dset = Dal.GetAllStates(CountryID);
            return (dset);
        }
    }
}






           