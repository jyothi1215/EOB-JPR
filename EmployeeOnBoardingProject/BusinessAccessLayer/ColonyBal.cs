 using EmployeeOnBoardingProject.DataAccessLayer;
using EmployeeOnBoardingProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace EmployeeOnBoardingProject.BusinessAccessLayer
{
    public class ColonyBal: IColonies
    {
        public DataSet GetAllColonies(int CityID)
        {
            ColonyDal dal = new ColonyDal();
            DataSet dset = dal.GetAllColonies(CityID);
            return (dset);
        



        }
    }
}