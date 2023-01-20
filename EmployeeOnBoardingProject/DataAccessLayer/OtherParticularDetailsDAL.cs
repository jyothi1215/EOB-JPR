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
    public class OtherParticularDetailsDAL : IEmp_OtherParticularDetails
    {

        public int ADDOtherParticularDetails(EmpOtherparticularDetails OPD)

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
                cmd.CommandText = Common.Usp_InsertOtherParticularDetails;



                cmd.Parameters.AddWithValue("@EmployeeID", OPD.EmployeeID);
                cmd.Parameters.AddWithValue("@EarliestDOJ", OPD.EarliestDOJ);

                cmd.Parameters.AddWithValue("@CurrentSalary", OPD.CurrentSalary);
                cmd.Parameters.AddWithValue("@ReferenceEmployeeID", OPD.ReferenceEmployeeID);
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


        public int UpdateOtherParticularDetails(EmpOtherparticularDetails OPD)

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
                cmd.CommandText = Common.Usp_UpdateOtherParticularDetails;
                cmd.Parameters.AddWithValue("@OPDID", OPD.OPDID);
                cmd.Parameters.AddWithValue("@EmployeeID", OPD.EmployeeID);
                cmd.Parameters.AddWithValue("@EarliestDOJ", OPD.EarliestDOJ);
                cmd.Parameters.AddWithValue("@CurrentSalary", OPD.CurrentSalary);
                cmd.Parameters.AddWithValue("@ReferenceEmployeeID", OPD.ReferenceEmployeeID);
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
        public int DeleteOtherParticularDetails(EmpOtherparticularDetails OPD)

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
                cmd.CommandText = Common.Usp_DeleteOtherParticularDetails;

                cmd.Parameters.AddWithValue("@EmployeeID", OPD.EmployeeID);
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

        public DataSet GetALLOtherParticularDetails(EmpOtherparticularDetails OPD)
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
                cmd.CommandText = Common.Usp_GetOtherParticularDetails;


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

        public DataSet GetAllRefEmpIds()
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


        

    
