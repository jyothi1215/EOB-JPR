using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Repositories
{
    interface ISignUp
    {
        int InsertUserDetails(UserRegisteration ur);
        int UpdateUserDetails(UserRegisteration ur);
        int DeleteUserDetails(UserRegisteration ur);
        DataSet GetAllUserDetails(UserRegisteration ur);
    }
}