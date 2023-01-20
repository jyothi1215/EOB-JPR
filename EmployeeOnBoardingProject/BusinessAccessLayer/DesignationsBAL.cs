using EmployeeOnBoardingProject.DataAccessLayer;
using EmployeeOnBoardingProject.Models;
using EmployeeOnBoardingProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.BusinessAccessLayer
{
    public class DesignationsBAL : IDesignations
    {
        public DataSet GetDesignationsDetails()
        {
            DesignationsDAL dal = new DesignationsDAL();
            DataSet dset = dal.GetDesignationsDetails();
            return (dset);
        }



        public DataSet GetDesignationsDetailsbyID(Designations Dd)
        {
            DesignationsDAL dal = new DesignationsDAL();
            DataSet dset = dal.GetDesignationsDetailsbyID(Dd);
            return (dset);
        }
    }
}