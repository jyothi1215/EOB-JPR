using EmployeeOnBoardingProject.CommonUtilities;
using EmployeeOnBoardingProject.Repositories;
using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.DataAccessLayer
{
    public class CollegesDal : IColleges
    {
        public DataSet GetAllCollegesByUniversityID(int UniversityID)

        {
            SqlConnection cn = null;
            SqlCommand cmd = null;

            SqlDataAdapter sda = null;
            DataSet dSet = null;

            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = Common.GetConnectionString();

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Common.Usp_GetCollegesDetailsByUniversityID;
                cmd.Parameters.AddWithValue("@UniversityID", UniversityID);

                cn.Open();

                sda = new SqlDataAdapter(cmd);
                dSet = new DataSet("Users");

                //Fill is the function, that executes store procedure
                //and fill the dSet with the incoming Records.
                sda.Fill(dSet, "User");


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return dSet;
        }

        

        public DataSet GetAllColleges()
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;

            SqlDataAdapter sda = null;
            DataSet dSet = null;

            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = Common.GetConnectionString();

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Common.Usp_GetCollegesDetailsByCollegeID;
                //cmd.Parameters.AddWithValue("@CollegeID", CollegeID);

                cn.Open();

                sda = new SqlDataAdapter(cmd);
                dSet = new DataSet("Users");

                //Fill is the function, that executes store procedure
                //and fill the dSet with the incoming Records.
                sda.Fill(dSet, "User");


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return dSet;


        }

    }
}












   









        