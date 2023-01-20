using EmployeeOnBoardingProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using EmployeeOnBoardingProject.CommonUtilities;

namespace EmployeeOnBoardingProject.DataAccessLayer
{
    public class StateDal : IStates
    {
        public DataSet GetAllStates(int CountryID)
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
                cmd.CommandText = Common.Usp_GetStatesDetailsByCountryID;
                cmd.Parameters.AddWithValue("@CountryID ", CountryID);


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




      