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
    public class DesignationsDAL : IDesignations
    {
        public DataSet GetDesignationsDetails()

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
                cmd.CommandText = Common.Usp_GetDesignationsDetails;

                //cmd.Parameters.AddWithValue("@DesignationID", dd.DesignationID);

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




        public DataSet GetDesignationsDetailsbyID(Designations Dd)
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
                    cmd.CommandText = Common.Usp_GetDesignationsDetailsByDesignationID;
                    cmd.Parameters.AddWithValue("@DesignationID", Dd.DesignationID);

                    cn.Open();

                    sda = new SqlDataAdapter(cmd);
                    dSet = new DataSet("Emp");

                    //Fill is the function, that executes store procedure
                    //and fill the dSet with the incoming Records.
                    sda.Fill(dSet, "Emp");


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

