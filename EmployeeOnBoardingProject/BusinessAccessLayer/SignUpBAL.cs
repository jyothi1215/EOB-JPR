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
    public class SignUpBAL : ISignUp
    {
        public int DeleteUserDetails(UserRegisteration ur)
        {
            SignUpDAL dal = new SignUpDAL();
            int Counter = 0;

            try
            {
                Counter = dal.DeleteUserDetails(ur);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }


        public DataSet GetAllUserDetails(UserRegisteration ur)
        {
            SignUpDAL dal = new SignUpDAL();
            DataSet dset = dal.GetAllUserDetails(ur);
            return (dset);
        }

        public int InsertUserDetails(UserRegisteration ur)
        {
            SignUpDAL dal = new SignUpDAL();
            int Counter = 0;

            try
            {
                Counter = dal.InsertUserDetails(ur);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }


        public int UpdateUserDetails(UserRegisteration ur)
        {
            SignUpDAL dal = new SignUpDAL();
            int Counter = 0;

            try
            {
                Counter = dal.UpdateUserDetails(ur);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return (Counter);


        }
    }
}


    



    
