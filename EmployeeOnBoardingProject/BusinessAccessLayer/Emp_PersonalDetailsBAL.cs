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
    public class Emp_PersonalDetailsBAL: IEmp_PersonalDetails
    {
        public int InsertEmployeeDetails(EmployeeDetails Ed)
        {
            Emp_PersonalDetailsDAL dal = new Emp_PersonalDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.InsertEmployeeDetails(Ed);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }
        public DataSet GetAllEmployeeDetails(EmployeeDetails Ed)
        {
            Emp_PersonalDetailsDAL dal = new Emp_PersonalDetailsDAL();
            DataSet dSet = null;
            try
            {
                dSet = dal.GetAllEmployeeDetails(Ed);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dSet;
        }


        public int UpdatePersonalDetails(EmployeeDetails Ed)
        {
            Emp_PersonalDetailsDAL dal = new Emp_PersonalDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.UpdatePersonalDetails(Ed);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }

        public int DeleteEmpDetails(EmployeeDetails Ed)
        {
             Emp_PersonalDetailsDAL dal = new Emp_PersonalDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.DeleteEmpDetails(Ed);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }
    }


}

