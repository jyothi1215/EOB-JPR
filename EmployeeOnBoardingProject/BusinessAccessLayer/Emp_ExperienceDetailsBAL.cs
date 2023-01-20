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
    public class Emp_ExperienceDetailsBAL : IEmp_ExperienceDetails
    {
        public int ADDEmpExperienceDetails(ExperienceDetails Exd)
        {
            Emp_ExperienceDetailsDAL dal = new Emp_ExperienceDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.ADDEmpExperienceDetails(Exd);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }

        public DataSet GetAllEmpExperienceDetails(ExperienceDetails Exd)
        {
            Emp_ExperienceDetailsDAL dal = new Emp_ExperienceDetailsDAL();
            DataSet dset = dal.GetAllEmpExperienceDetails(Exd);
            return (dset);
        }

        public int DeleteEmpExperienceDetails(ExperienceDetails Exd)
        {
            Emp_ExperienceDetailsDAL dal = new Emp_ExperienceDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.DeleteEmpExperienceDetails(Exd);

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

        public int UpdateEmpExperienceDetails(ExperienceDetails Exd)
        {
            Emp_ExperienceDetailsDAL dal = new Emp_ExperienceDetailsDAL();
            int Counter = 0;

            try
            {
                Counter = dal.UpdateEmpExperienceDetails(Exd);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }
    }
}
    

    

    

        