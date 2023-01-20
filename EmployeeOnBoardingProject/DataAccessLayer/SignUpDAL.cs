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
    public class SignUpDAL:ISignUp
    {
        public int InsertUserDetails(UserRegisteration ur)
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
                cmd.CommandText = Common.USP_USERREGISTERATION_INSERT;
                cmd.Parameters.AddWithValue("@FirstName", ur.FirstName);
                cmd.Parameters.AddWithValue("@LastName", ur.LastName);
                cmd.Parameters.AddWithValue("@Email", ur.Email);
                cmd.Parameters.AddWithValue("@Password",ur.Password);
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

        public int UpdateUserDetails(UserRegisteration ur)
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
                cmd.CommandText = Common.USP_USERREGISTERATION_UPDATE;
                cmd.Parameters.AddWithValue("@UserId", ur.UserID);
                cmd.Parameters.AddWithValue("@FirstName", ur.FirstName);
                cmd.Parameters.AddWithValue("@LastName", ur.LastName);
                cmd.Parameters.AddWithValue("@Email", ur.Email);
                cmd.Parameters.AddWithValue("@Password", ur.Password);
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
        public int DeleteUserDetails(UserRegisteration ur)
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
                cmd.CommandText = Common.USP_USERREGISTERATION_DELETE;
                cmd.Parameters.AddWithValue("@UserId", ur.UserID);
                
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
        public DataSet GetAllUserDetails(UserRegisteration ur)
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
                cmd.CommandText = Common.USP_GETALLUSERS;


                con.Open();

                sda = new SqlDataAdapter(cmd);
                dSet = new DataSet("UserDetails");

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


    }
} 