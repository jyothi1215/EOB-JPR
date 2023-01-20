using EmployeeOnBoardingProject.DataAccessLayer;
using EmployeeOnBoardingProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.BusinessAccessLayer
{
    public class CollegesBal : IColleges
    {

        public DataSet GetAllCollegesByUniversityID(int UniversityID)
        {
            CollegesDal dal = new CollegesDal();
            DataSet dset = dal.GetAllCollegesByUniversityID(UniversityID);

            return (dset);
        }

        public DataSet GetAllColleges()
        {
            CollegesDal dal = new CollegesDal();
            DataSet dset = dal.GetAllColleges();
            return (dset);
        }
    }
}
    





