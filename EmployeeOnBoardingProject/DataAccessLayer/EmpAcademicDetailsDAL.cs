using EmployeeOnBoardingProject.CommonUtilities;
using EmployeeOnBoardingProject.Models;
using EmployeeOnBoardingProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.DataAccessLayer
{
    public class EmpAcademicDetailsDAL : IEmp_AcademicDetails
    {
        public DataSet GetAllEmpAcademicDetails(AcademicDetails Ad)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            SqlDataAdapter sda = null;
            DataSet dSet = null;

            try
            {
                con = new SqlConnection();
                con.ConnectionString = Common.GetConnectionString();

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Common.Usp_GetAcademicDetails;


                con.Open();

                sda = new SqlDataAdapter(cmd);
                dSet = new DataSet("Roles");

                //Fill is the function, that executes store procedure
                //and fill the dSet with the incoming Records.
                sda.Fill(dSet, "Rows");


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;
                }
            }
            return dSet;

        }


        public int ADD_EmpAcademicDetails(AcademicDetails Ad)
        {

            SqlConnection con = null;
            SqlCommand cmd = null;
            int Counter = 0;

            try
            {
                con = new SqlConnection();
                con.ConnectionString = Common.GetConnectionString();

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Common.Usp_InsertAcademicDetails;

                //cmd.Parameters.AddWithValue("@AcademicDetailsID", Ad.AcademicDetailsID);
                cmd.Parameters.AddWithValue("@EmployeeID", Ad.EmployeeID);
                cmd.Parameters.AddWithValue("@Qualification", Ad.Qualification);
                cmd.Parameters.AddWithValue("@UniversityID", Ad.UniversityID);
                cmd.Parameters.AddWithValue("@CollegeID", Ad.CollegeID);
                cmd.Parameters.AddWithValue("@Year", Ad.Year);
                cmd.Parameters.AddWithValue("@Percentage", Ad.Percentage);
                con.Open();
                Counter = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (con != null)
                {

                    con.Close();
                    con.Dispose();
                    con = null;
                }

            }
            return (Counter);

        }

        public DataSet GetAllEmpID()
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
                cmd.CommandText = Common.Usp_GetEmpNamesbyID;
                //cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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

        public int Update_EmpAcademicDetails(AcademicDetails Ad)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int Counter = 0;

            try
            {
                con = new SqlConnection();
                con.ConnectionString = Common.GetConnectionString();

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Common.Usp_UpdateAcademicDetails;

                cmd.Parameters.AddWithValue("@AcademicDetailsID", Ad.AcademicDetailsID);
                cmd.Parameters.AddWithValue("@EmployeeID", Ad.EmployeeID);
                cmd.Parameters.AddWithValue("@Qualification", Ad.Qualification);
                cmd.Parameters.AddWithValue("@UniversityID", Ad.UniversityID);
                cmd.Parameters.AddWithValue("@CollegeID", Ad.CollegeID);
                cmd.Parameters.AddWithValue("@Year", Ad.Year);
                cmd.Parameters.AddWithValue("@Percentage", Ad.Percentage);
                con.Open();
                Counter = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (con != null)
                {

                    con.Close();
                    con.Dispose();
                    con = null;
                }

            }
            return (Counter);

        }


        public int DeleteEmpDetails(AcademicDetails Ad)
        {

            SqlConnection con = null;
            SqlCommand cmd = null;
            int Counter = 0;

            try
            {
                con = new SqlConnection();
                con.ConnectionString = Common.GetConnectionString();

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Common.Usp_DeleteAcademicDetails;
                cmd.Parameters.AddWithValue("@AcademicDetailsID", Ad.AcademicDetailsID); 

                con.Open();
                Counter = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (con != null)
                {

                    con.Close();
                    con.Dispose();
                    con = null;
                }

            }
            return (Counter);
        }
    }
}














