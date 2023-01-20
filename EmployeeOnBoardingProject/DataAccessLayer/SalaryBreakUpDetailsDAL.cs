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
    public class SalaryBreakUpDetailsDAL : IEmp_SalaryBreakUpDetails
    {
        public int ADDSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd)

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
                cmd.CommandText = Common.Usp_InsertSalaryBreakUpDetails;

                cmd.Parameters.AddWithValue("@EmployeeID", Sbd.EmployeeID);
                cmd.Parameters.AddWithValue("@ParticularName", Sbd.ParticularName);
                cmd.Parameters.AddWithValue("@ParticularAmount", Sbd.ParticularAmount);
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


        public int UpdateSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd)

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
                cmd.CommandText = Common.Usp_UpdateSalaryBreakUpDetails;
                cmd.Parameters.AddWithValue("SBDID", Sbd.SBDID);
                cmd.Parameters.AddWithValue("@EmployeeID", Sbd.EmployeeID);
                cmd.Parameters.AddWithValue("@ParticularName", Sbd.ParticularName);
                cmd.Parameters.AddWithValue("@ParticularAmount", Sbd.ParticularAmount);
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
        public int DeleteSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd)

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
                cmd.CommandText = Common.Usp_DeleteSalaryBreakUpDetails;


                cmd.Parameters.AddWithValue("@EmployeeID", Sbd.EmployeeID);

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

        public DataSet GetAllSalaryBreakUpDetails(EmpSalBreakUpDetails Sbd)
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
                cmd.CommandText = Common.Usp_GetSalaryBreakUpDetails;


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

        
    }


}
    