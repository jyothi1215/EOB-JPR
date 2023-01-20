using EmployeeOnBoardingProject.DataAccessLayer;
using EmployeeOnBoardingProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.BusinessAccessLayer
{
    public class SkillsBAL : ISkills
    {
        public DataSet GetSkillsDetails()
        {
            SkillsDAL dal = new SkillsDAL();
            DataSet dset = dal.GetSkillsDetails();
            return (dset);

        }
    }
}