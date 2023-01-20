using EmployeeOnBoardingProject.DataAccessLayer;
using EmployeeOnBoardingProject.Repositories;
using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.BusinessAccessLayer
{
    public class UniversitiesBAL : IUniversities
    {
      
        public DataSet GellAllUniversities()
        {
            UniversitiesDAL dal = new UniversitiesDAL();
            DataSet dSet = dal.GellAllUniversities();

            return (dSet);
        }

        
    }
}

















