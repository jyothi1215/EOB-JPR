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
    public class OtherParticularDetailsBAL : IEmp_OtherParticularDetails
    {
        public int ADDOtherParticularDetails(EmpOtherparticularDetails OPD)
        {
            OtherParticularDetailsDAL dal = new OtherParticularDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.ADDOtherParticularDetails(OPD);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }

        public int DeleteOtherParticularDetails(EmpOtherparticularDetails OPD)
        {
            OtherParticularDetailsDAL dal = new OtherParticularDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.DeleteOtherParticularDetails(OPD);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }

        public DataSet GetALLOtherParticularDetails(EmpOtherparticularDetails OPD)
        {
            OtherParticularDetailsDAL dal = new OtherParticularDetailsDAL();
            DataSet dset = dal.GetALLOtherParticularDetails(OPD);
            return (dset);
        }

        public DataSet GetAllEmpID()
        {
            OtherParticularDetailsDAL dal = new OtherParticularDetailsDAL();
            DataSet dset = dal.GetAllEmpID();
            return (dset);
        }

        
        public int UpdateOtherParticularDetails(EmpOtherparticularDetails OPD)
        {
            OtherParticularDetailsDAL dal = new OtherParticularDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.UpdateOtherParticularDetails(OPD);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }

        public DataSet GetAllRefEmpIds()
        {
            OtherParticularDetailsDAL dal = new OtherParticularDetailsDAL();
            DataSet dset = dal.GetAllEmpID();
            return (dset);
        }
    }
}


    

        