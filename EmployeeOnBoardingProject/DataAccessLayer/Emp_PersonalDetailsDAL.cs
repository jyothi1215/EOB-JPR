using EmployeeOnBoardingProject.Models;
using EmployeeOnBoardingProject.Repositories;
using EmployeeOnBoardingProject.BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using EmployeeOnBoardingProject.CommonUtilities;
using System.Data;

namespace EmployeeOnBoardingProject.DataAccessLayer
{
    public class Emp_PersonalDetailsDAL : IEmp_PersonalDetails
    {

        public int InsertEmployeeDetails(EmployeeDetails Ed)
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
                cmd.CommandText = Common.Usp_insertPersonalDetails;
                //cmd.Parameters.AddWithValue("@EmployeeID", Ed.EmployeeID);
                cmd.Parameters.AddWithValue("@EmployeeFirstName", Ed.EmployeeFirstName);
                cmd.Parameters.AddWithValue("@EmployeeMiddleName", Ed.EmployeeMiddleName);
                cmd.Parameters.AddWithValue("@EmployeeSurName", Ed.EmployeeSurName);
                cmd.Parameters.AddWithValue("@BloodGroup", Ed.BloodGroup);
                cmd.Parameters.AddWithValue("@DateOfBirth", Ed.DateOfBirth);
                cmd.Parameters.AddWithValue("@PhoneNo ", Ed.PhoneNo);
                cmd.Parameters.AddWithValue("@AlternatePhoneNo ", Ed.AlternatePhoneNo);
                cmd.Parameters.AddWithValue("@MailID", Ed.MailID);
                cmd.Parameters.AddWithValue("@MaritalStatus", Ed.MaritalStatus);
                cmd.Parameters.AddWithValue("@Gender", Ed.Gender);
                cmd.Parameters.AddWithValue("@PermanentCountryID ", Ed.PermanentCountryID);
                cmd.Parameters.AddWithValue("@PermanentStateID ", Ed.PermanentStateID);
                cmd.Parameters.AddWithValue("@PermanentCityID ", Ed.PermanentCityID);
                cmd.Parameters.AddWithValue("@PermanentColonyID ", Ed.PermanentColonyID);
                cmd.Parameters.AddWithValue("@PermanentHouseNo ", Ed.PermanentHouseNo);
                cmd.Parameters.AddWithValue("@TemporaryCountryID ", Ed.TemporaryCountryID);
                cmd.Parameters.AddWithValue("@TemporaryStateID ", Ed.TemporaryStateID);
                cmd.Parameters.AddWithValue("@TemporaryCityID ", Ed.TemporaryCityID);
                cmd.Parameters.AddWithValue("@TemporaryColonyID ", Ed.TemporaryColonyID);
                cmd.Parameters.AddWithValue("@TemporaryHouseNo ", Ed.TemporaryHouseNo);

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

        public DataSet GetAllEmployeeDetails(EmployeeDetails Ed)
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
                cmd.CommandText = Common.Usp_GetAllEmployeeDetails;


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
        public int UpdatePersonalDetails(EmployeeDetails Ed)
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
                cmd.CommandText = Common.Usp_UpdatePersonalDetails;
                cmd.Parameters.AddWithValue("@EmployeeID", Ed.EmployeeID);
                cmd.Parameters.AddWithValue("@EmployeeFirstName", Ed.EmployeeFirstName);
                cmd.Parameters.AddWithValue("@EmployeeMiddleName", Ed.EmployeeMiddleName);
                cmd.Parameters.AddWithValue("@EmployeeSurName", Ed.EmployeeSurName);
                cmd.Parameters.AddWithValue("@BloodGroup", Ed.BloodGroup);
                cmd.Parameters.AddWithValue("@DateOfBirth", Ed.DateOfBirth);
                cmd.Parameters.AddWithValue("@PhoneNo ", Ed.PhoneNo);
                cmd.Parameters.AddWithValue("@AlternatePhoneNo ", Ed.AlternatePhoneNo);
                cmd.Parameters.AddWithValue("@MailID", Ed.MailID);
                cmd.Parameters.AddWithValue("@MaritalStatus", Ed.MaritalStatus);
                cmd.Parameters.AddWithValue("@Gender", Ed.Gender);
                cmd.Parameters.AddWithValue("@PermanentCountryID ", Ed.PermanentCountryID);
                cmd.Parameters.AddWithValue("@PermanentStateID ", Ed.PermanentStateID);
                cmd.Parameters.AddWithValue("@PermanentCityID ", Ed.PermanentCityID);
                cmd.Parameters.AddWithValue("@PermanentColonyID ", Ed.PermanentColonyID);
                cmd.Parameters.AddWithValue("@PermanentHouseNo ", Ed.PermanentHouseNo);
                cmd.Parameters.AddWithValue("@TemporaryCountryID ", Ed.TemporaryCountryID);
                cmd.Parameters.AddWithValue("@TemporaryStateID ", Ed.TemporaryStateID);
                cmd.Parameters.AddWithValue("@TemporaryCityID ", Ed.TemporaryCityID);
                cmd.Parameters.AddWithValue("@TemporaryColonyID ", Ed.TemporaryColonyID);
                cmd.Parameters.AddWithValue("@TemporaryHouseNo ", Ed.TemporaryHouseNo);

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

        public int DeleteEmpDetails(EmployeeDetails Ed)
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
                cmd.CommandText = Common.Usp_DeletePersonalDetails;
                cmd.Parameters.AddWithValue("@EmployeeID", Ed.EmployeeID);



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
        




        


    
