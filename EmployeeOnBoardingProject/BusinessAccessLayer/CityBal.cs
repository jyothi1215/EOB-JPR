using EmployeeOnBoardingProject.DataAccessLayer;
using EmployeeOnBoardingProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.BusinessAccessLayer
{
    public class CityBal: ICities
    {
        public DataSet GetAllCities(int StateID)
        {
            CityDal dal = new CityDal();
            DataSet dset = dal.GetAllCities(StateID);
            return (dset);




        }


    }
}