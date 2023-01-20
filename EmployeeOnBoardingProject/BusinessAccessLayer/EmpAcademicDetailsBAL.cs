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
    public class EmpAcademicDetailsBAL : IEmp_AcademicDetails
    {

        public DataSet GetAllEmpAcademicDetails(AcademicDetails Ad)
        {
            EmpAcademicDetailsDAL dal = new EmpAcademicDetailsDAL();
            DataSet dSet = null;

            try
            {
                dSet = dal.GetAllEmpAcademicDetails(Ad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return (dSet);
        }
        public int ADD_EmpAcademicDetails(AcademicDetails Ad)
        {
            EmpAcademicDetailsDAL dal = new EmpAcademicDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.ADD_EmpAcademicDetails(Ad);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }

        public DataSet GetAllEmpID()
        {
            EmpAcademicDetailsDAL dal = new EmpAcademicDetailsDAL();
            DataSet dSet = dal.GetAllEmpID();

            return (dSet);



        }

        public int Update_EmpAcademicDetails(AcademicDetails Ad)
        {
            EmpAcademicDetailsDAL dal = new EmpAcademicDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.Update_EmpAcademicDetails(Ad);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }

        public int DeleteEmpDetails(AcademicDetails Ad)
        {
            EmpAcademicDetailsDAL dal = new EmpAcademicDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.DeleteEmpDetails(Ad);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }
    }
}
    











