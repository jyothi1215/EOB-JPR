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
    public class SalaryBreakUpDetailsBAL : IEmp_SalaryBreakUpDetails
    {
        public int ADDSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd)
        {
            SalaryBreakUpDetailsDAL dal = new SalaryBreakUpDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.ADDSalaryBreakUpDetails(Sbd);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }

        public int DeleteSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd)
        {
            SalaryBreakUpDetailsDAL dal = new SalaryBreakUpDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.DeleteSalaryBreakUpDetails(Sbd);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }
    

        public DataSet GetAllEmpID()
        {
            Emp_ExperienceDetailsDAL dal = new Emp_ExperienceDetailsDAL();
            DataSet dset = dal.GetAllEmpID();
            return (dset);
        }

        public DataSet GetAllSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd)
        {
            SalaryBreakUpDetailsDAL dal = new SalaryBreakUpDetailsDAL();
            DataSet dset = dal.GetAllSalaryBreakUpDetails(Sbd);
            return (dset);
        }

        

        public int UpdateSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd)
        {
            SalaryBreakUpDetailsDAL dal = new SalaryBreakUpDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.UpdateSalaryBreakUpDetails(Sbd);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }

    }
}
   
