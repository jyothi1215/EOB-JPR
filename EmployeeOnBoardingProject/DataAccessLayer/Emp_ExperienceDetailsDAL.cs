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
    public class Emp_ExperienceDetailsDAL : IEmp_ExperienceDetails
    {
        public int ADDEmpExperienceDetails(ExperienceDetails Exd)
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
                cmd.CommandText = Common.Usp_InsertExperienceDetails;
                //cmd.Parameters.AddWithValue("@ExperienceDetailsID", Exd.ExperienceDetailsID);
                cmd.Parameters.AddWithValue("@EmployeeID", Exd.EmployeeID);
                cmd.Parameters.AddWithValue("@Organization", Exd.Organization);
                cmd.Parameters.AddWithValue("@DesignationID", Exd.DesignationID);
                cmd.Parameters.AddWithValue("@FromDate", Exd.FromDate);
                cmd.Parameters.AddWithValue("@ToDate", Exd.ToDate);
                cmd.Parameters.AddWithValue("@SkillID", Exd.SkillID);

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

        public DataSet GetAllEmpExperienceDetails(ExperienceDetails Exd)
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
                cmd.CommandText = Common.usp_GetAllEmpExpDetails;



                con.Open();

                sda = new SqlDataAdapter(cmd);
                dSet = new DataSet("EmployeeDetails");

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


        public int DeleteEmpExperienceDetails(ExperienceDetails Exd)
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
                cmd.CommandText = Common.Usp_DeleteExperienceDetails;
                cmd.Parameters.AddWithValue("@EmployeeID", Exd.EmployeeID);

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



        public int UpdateEmpExperienceDetails(ExperienceDetails Exd)
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
                cmd.CommandText = Common.Usp_UpdateExperienceDetails;
                cmd.Parameters.AddWithValue("@ExperienceDetailsID", Exd.ExperienceDetailsID);
                cmd.Parameters.AddWithValue("@EmployeeID", Exd.EmployeeID);
                cmd.Parameters.AddWithValue("@Organization", Exd.Organization);
                cmd.Parameters.AddWithValue("@DesignationID", Exd.DesignationID);
                cmd.Parameters.AddWithValue("@FromDate", Exd.FromDate);
                cmd.Parameters.AddWithValue("@ToDate", Exd.ToDate);
                cmd.Parameters.AddWithValue("@SkillID", Exd.SkillID);



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


   





            