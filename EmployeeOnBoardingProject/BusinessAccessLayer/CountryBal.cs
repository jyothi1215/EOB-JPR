using EmployeeOnBoardingProject.DataAccessLayer;
using EmployeeOnBoardingProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.BusinessAccessLayer
{
    public class CountryBal:ICountries
    {
        public DataSet GetAllCountries()
        {
            CountryDal obj = new CountryDal();
            DataSet dset = obj.GetAllCountries();
            return (dset);



        }






    }
}