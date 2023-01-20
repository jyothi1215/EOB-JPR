using EmployeeOnBoardingProject.BusinessAccessLayer;
using EmployeeOnBoardingProject.DataAccessLayer;
using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace EmployeeOnBoardingProject.PresentationLayer
{
    public partial class Insert_EmployeePersonalDetails : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                GetEmployeeDetails();
                GetCountries();
                GetTempCountries();
                
                

            }
        }

        

        private void GetTempCountries()
        {

            CountryBal Bal = new CountryBal();
            DataSet dSet = Bal.GetAllCountries();
            DDL7_TempCountry.DataSource = dSet;
            DDL7_TempCountry.DataTextField = "CountryName";
            DDL7_TempCountry.DataValueField = "CountryID";
            DDL7_TempCountry.DataBind();
            ListItem li = new ListItem("Please Select", "Please Select");
            DDL7_TempCountry.Items.Insert(0, li);



        }

        private void GetCountries()
        {

            CountryBal Bal = new CountryBal();
            DataSet dSet = Bal.GetAllCountries();
            DDL3_Country.DataSource = dSet;
            DDL3_Country.DataTextField = "CountryName";
            DDL3_Country.DataValueField = "CountryID";
            DDL3_Country.DataBind();
            ListItem li = new ListItem("Please Select", "Please Select");
            DDL3_Country.Items.Insert(0, li);



        }

        private void GetEmployeeDetails()
        {

            EmployeeDetails Ed = new EmployeeDetails();
            Emp_PersonalDetailsBAL bal = new Emp_PersonalDetailsBAL();
            DataSet dSet = bal.GetAllEmployeeDetails(Ed);

            dSet = bal.GetAllEmployeeDetails(Ed);

            GridView1.DataSource = dSet;
            GridView1.DataBind();



        }


        protected void Button1_Click_Insert(object sender, EventArgs e)
        {

            EmployeeDetails Ed = new EmployeeDetails();
            Emp_PersonalDetailsBAL bal = new Emp_PersonalDetailsBAL();
            try
            {
                //Ed.EmployeeID = Convert.ToInt32(TextBox1.Text.ToString());
                Ed.EmployeeFirstName = TextBox2.Text;
                Ed.EmployeeMiddleName = TextBox3.Text;
                Ed.EmployeeSurName = TextBox4.Text;
                Ed.BloodGroup = DDL1_Bloodgroup.SelectedItem.Value;
                Ed.DateOfBirth = DateTime.Parse(TextBox5.Text);
                Ed.PhoneNo = TextBox6.Text;
                Ed.AlternatePhoneNo = TextBox7.Text;
                Ed.MailID = TextBox8.Text;
                Ed.MaritalStatus = DDL2_MaritalStatus.SelectedItem.Value;
                Ed.Gender = Rdb_Gender.SelectedValue;

                Ed.PermanentCountryID = Convert.ToInt32(DDL3_Country.SelectedItem.Value);
                Ed.PermanentStateID = Convert.ToInt32(DDL4_State.SelectedItem.Value);
                Ed.PermanentCityID = Convert.ToInt32(DDL5_City.SelectedItem.Value);
                Ed.PermanentColonyID = Convert.ToInt32(DDL6_Colony.SelectedItem.Value);
                Ed.PermanentHouseNo = TextBox9.Text;
                Ed.TemporaryCountryID = Convert.ToInt32(DDL7_TempCountry.SelectedItem.Value);
                Ed.TemporaryStateID = Convert.ToInt32(DDL8_TempState.SelectedItem.Value);
                Ed.TemporaryCityID = Convert.ToInt32(DDL9_TempCity.SelectedItem.Value);
                Ed.TemporaryColonyID = Convert.ToInt32(DDL10_TempColony.SelectedItem.Value);
                Ed.TemporaryHouseNo = TextBox10.Text;

                int Counter = bal.InsertEmployeeDetails(Ed);
                GetEmployeeDetails();
                Label22.Text = "<h2>Employee's Personal Details added successfully..</h2>";

            }
            catch (Exception ex)
            {
                Label22.Text = ex.Message;

            }
        }
                                
         protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gvr = GridView1.SelectedRow;
            TextBox1.Text = gvr.Cells[1].Text;
            TextBox2.Text = gvr.Cells[2].Text;
            TextBox3.Text = gvr.Cells[3].Text;
            TextBox4.Text = gvr.Cells[4].Text;
            DDL1_Bloodgroup.SelectedValue = gvr.Cells[5].Text;
            TextBox5.Text = gvr.Cells[6].Text;
            TextBox6.Text = gvr.Cells[7].Text;
            TextBox7.Text = gvr.Cells[8].Text;
            TextBox8.Text = gvr.Cells[9].Text;
            DDL2_MaritalStatus.SelectedValue = gvr.Cells[10].Text;
            Rdb_Gender.SelectedValue = gvr.Cells[11].Text;
            
            DDL3_Country.Text = gvr.Cells[12].Text;
            BindStates1();
            DDL4_State.Text = gvr.Cells[13].Text;
            BindCities();
            DDL5_City.Text = gvr.Cells[14].Text;
            BindColonies();
            DDL6_Colony.Text = gvr.Cells[15].Text;
            
            TextBox9.Text = gvr.Cells[16].Text;
            DDL7_TempCountry.SelectedValue = gvr.Cells[17].Text;
            BindTempstates();
            DDL8_TempState.Text = gvr.Cells[18].Text;
            BindTempCities();
            DDL9_TempCity.Text = gvr.Cells[19].Text;
            Bindtempcolonies();
            DDL10_TempColony.Text = gvr.Cells[20].Text;
            TextBox10.Text = gvr.Cells[21].Text;
        }

        //protected void Btn1_update_Click(object sender, EventArgs e)

        //{
        //    EmployeeDetails Ed = new EmployeeDetails();
        //    Emp_PersonalDetailsBAL bal = new Emp_PersonalDetailsBAL();
        //    try
        //    {
        //        Ed.EmployeeID = Convert.ToInt32(TextBox1.Text);
        //        Ed.EmployeeFirstName = TextBox2.Text;
        //        Ed.EmployeeMiddleName = TextBox3.Text;
        //        Ed.EmployeeSurName = TextBox4.Text;
        //        Ed.BloodGroup = DDL1_Bloodgroup.SelectedItem.Value;
        //        Ed.DateOfBirth = DateTime.Parse(TextBox5.Text);
        //        Ed.PhoneNo = TextBox6.Text;
        //        Ed.AlternatePhoneNo = TextBox7.Text;
        //        Ed.MailID = TextBox8.Text;
        //        Ed.MaritalStatus = DDL2_MaritalStatus.SelectedItem.Value;
        //        Ed.Gender = Rdb_Gender.SelectedItem.Value;
        //        Ed.PermanentCountryID = Convert.ToInt32(DDL3_Country.SelectedItem.Value);
        //        Ed.PermanentStateID = Convert.ToInt32(DDL4_State.SelectedItem.Value);
        //        Ed.PermanentCityID = Convert.ToInt32(DDL5_City.SelectedItem.Value);
        //        Ed.PermanentColonyID = Convert.ToInt32(DDL6_Colony.SelectedItem.Value);
        //        Ed.PermanentHouseNo = TextBox9.Text;
        //        Ed.TemporaryCountryID = Convert.ToInt32(DDL7_TempCountry.SelectedItem.Value);
        //        Ed.TemporaryStateID = Convert.ToInt32(DDL8_TempState.SelectedItem.Value);
        //        Ed.TemporaryCityID = Convert.ToInt32(DDL9_TempCity.SelectedItem.Value);
        //        Ed.TemporaryColonyID = Convert.ToInt32(DDL10_TempColony.SelectedItem.Value);
        //        Ed.TemporaryHouseNo = TextBox10.Text;

        //        int Counter = bal.UpdatePersonalDetails(Ed);
        //        GetEmployeeDetails();
        //        Label22.Text = "<h2>Employee's Personal Details Updated successfully..</h2>";

        //    }
        //    catch (Exception ex)
        //    {
        //        Label22.Text = ex.Message;

        //    }

        //}

        //protected void Button3_Click_Delete(object sender, EventArgs e)
        //{
        //    EmployeeDetails Ed = new EmployeeDetails();
        //    Emp_PersonalDetailsBAL bal = new Emp_PersonalDetailsBAL();
        //    try
        //    {
        //        Ed.EmployeeID = Convert.ToInt32(TextBox1.Text.ToString());
        //        int Counter = bal.DeleteEmpDetails(Ed);

        //        Label22.Text = "<h2>Employee's Personal Details Deleted successfully..</h2>";


        //    }


        //    catch (Exception ex)
        //    {
        //        Label22.Text = ex.Message;

        //    }

        //}

        

     
         
   
        protected void DDL7_TempCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindTempstates();

        }

        private void BindTempstates()
        {
            int CountryID = Convert.ToInt32(DDL7_TempCountry.SelectedItem.Value.ToString());
            StateBal Bal = new StateBal();
            DataSet dSet = Bal.GetAllStates(CountryID);

            DDL8_TempState.DataSource = dSet;
            DDL8_TempState.DataTextField = "StateName";
            DDL8_TempState.DataValueField = "StateID";
            DDL8_TempState.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDL8_TempState.Items.Insert(0, li);


            DDL9_TempCity.Items.Clear();
        }

        protected void DDL8_TempState_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindTempCities();

        }

        private void BindTempCities()
        {
            int StateID = Convert.ToInt32(DDL8_TempState.SelectedItem.Value.ToString());
            CityBal bal = new CityBal();
            DataSet dSet = bal.GetAllCities(StateID);

            DDL9_TempCity.DataSource = dSet;
            DDL9_TempCity.DataTextField = "CityName";
            DDL9_TempCity.DataValueField = "CityID";
            DDL9_TempCity.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDL9_TempCity.Items.Insert(0, li);

            DDL10_TempColony.Items.Clear();
        }

        protected void DDL9_TempCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bindtempcolonies();

        }

        private void Bindtempcolonies()
        {
            int CityID = Convert.ToInt32(DDL9_TempCity.SelectedItem.Value.ToString());
            ColonyBal bal = new ColonyBal();
            DataSet dSet = bal.GetAllColonies(CityID);

            DDL10_TempColony.DataSource = dSet;
            DDL10_TempColony.DataTextField = "ColonyName";
            DDL10_TempColony.DataValueField = "ColonyID";
            DDL10_TempColony.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDL10_TempColony.Items.Insert(0, li);
        }

        protected void Btn1_Insert_Click(object sender, EventArgs e)
        {
            EmployeeDetails Ed = new EmployeeDetails();
            Emp_PersonalDetailsBAL bal = new Emp_PersonalDetailsBAL();
            {
                try
                {

                    Ed.EmployeeFirstName = TextBox2.Text;
                    Ed.EmployeeMiddleName = TextBox3.Text;
                    Ed.EmployeeSurName = TextBox4.Text;
                    Ed.BloodGroup = DDL1_Bloodgroup.SelectedItem.Value;
                    Ed.DateOfBirth = DateTime.Parse(TextBox5.Text);
                    Ed.PhoneNo = TextBox6.Text;
                    Ed.AlternatePhoneNo = TextBox7.Text;
                    Ed.MailID = TextBox8.Text;
                    Ed.MaritalStatus = DDL2_MaritalStatus.SelectedItem.Value;
                    Ed.Gender = Rdb_Gender.SelectedValue;

                    Ed.PermanentCountryID = Convert.ToInt32(DDL3_Country.SelectedItem.Value);
                    Ed.PermanentStateID = Convert.ToInt32(DDL4_State.SelectedItem.Value);
                    Ed.PermanentCityID = Convert.ToInt32(DDL5_City.SelectedItem.Value);
                    Ed.PermanentColonyID = Convert.ToInt32(DDL6_Colony.SelectedItem.Value);
                    Ed.PermanentHouseNo = TextBox9.Text;
                    Ed.TemporaryCountryID = Convert.ToInt32(DDL7_TempCountry.SelectedItem.Value);
                    Ed.TemporaryStateID = Convert.ToInt32(DDL8_TempState.SelectedItem.Value);
                    Ed.TemporaryCityID = Convert.ToInt32(DDL9_TempCity.SelectedItem.Value);
                    Ed.TemporaryColonyID = Convert.ToInt32(DDL10_TempColony.SelectedItem.Value);
                    Ed.TemporaryHouseNo = TextBox10.Text;

                    int Counter = bal.InsertEmployeeDetails(Ed);
                    GetEmployeeDetails();
                    Label22.Text = "<h2>Employee's Personal Details added successfully..</h2>";





                }
                catch (Exception ex)
                {

                    Label22.Text = ex.Message;
                }
            }

        }

        protected void Btn2_Update_Click(object sender, EventArgs e)
        {

            EmployeeDetails Ed = new EmployeeDetails();
            Emp_PersonalDetailsBAL bal = new Emp_PersonalDetailsBAL();
            try
            {
                Ed.EmployeeID = Convert.ToInt32(TextBox1.Text);
                Ed.EmployeeFirstName = TextBox2.Text;
                Ed.EmployeeMiddleName = TextBox3.Text;
                Ed.EmployeeSurName = TextBox4.Text;
                Ed.BloodGroup = DDL1_Bloodgroup.SelectedItem.Value;
                Ed.DateOfBirth = DateTime.Parse(TextBox5.Text);
                Ed.PhoneNo = TextBox6.Text;
                Ed.AlternatePhoneNo = TextBox7.Text;
                Ed.MailID = TextBox8.Text;
                Ed.MaritalStatus = DDL2_MaritalStatus.SelectedItem.Value;
                Ed.Gender = Rdb_Gender.SelectedItem.Value;
                Ed.PermanentCountryID = Convert.ToInt32(DDL3_Country.SelectedItem.Value);
                Ed.PermanentStateID = Convert.ToInt32(DDL4_State.SelectedItem.Value);
                Ed.PermanentCityID = Convert.ToInt32(DDL5_City.SelectedItem.Value);
                Ed.PermanentColonyID = Convert.ToInt32(DDL6_Colony.SelectedItem.Value);
                Ed.PermanentHouseNo = TextBox9.Text;
                Ed.TemporaryCountryID = Convert.ToInt32(DDL7_TempCountry.SelectedItem.Value);
                Ed.TemporaryStateID = Convert.ToInt32(DDL8_TempState.SelectedItem.Value);
                Ed.TemporaryCityID = Convert.ToInt32(DDL9_TempCity.SelectedItem.Value);
                Ed.TemporaryColonyID = Convert.ToInt32(DDL10_TempColony.SelectedItem.Value);
                Ed.TemporaryHouseNo = TextBox10.Text;

                int Counter = bal.UpdatePersonalDetails(Ed);
                GetEmployeeDetails();
                Label22.Text = "<h2>Employee's Personal Details Updated successfully..</h2>";

            }
            catch (Exception ex)
            {
                Label22.Text = ex.Message;

            }

        }

        protected void Btn3_Delete_Click(object sender, EventArgs e)
        {
            EmployeeDetails Ed = new EmployeeDetails();
            Emp_PersonalDetailsBAL bal = new Emp_PersonalDetailsBAL();
            try
            {
                Ed.EmployeeID = Convert.ToInt32(TextBox1.Text.ToString());
                int Counter = bal.DeleteEmpDetails(Ed);

                Label22.Text = "<h2>Employee's Personal Details Deleted successfully..</h2>";


            }


            catch (Exception ex)
            {
                Label22.Text = ex.Message;

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpAcademicDetails.aspx");
        }

        
        protected void DDL4_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCities();

        }

        private void BindCities()
        {
            int StateID = Convert.ToInt32(DDL4_State.SelectedItem.Value);
            CityBal bal = new CityBal();
            DataSet dSet = bal.GetAllCities(StateID);

            DDL5_City.DataSource = dSet;
            DDL5_City.DataTextField = "CityName";
            DDL5_City.DataValueField = "CityID";
            DDL5_City.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDL5_City.Items.Insert(0, li);
        }

        protected void DDL5_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindColonies();

        }

        private void BindColonies()
        {
            int CityID = Convert.ToInt32(DDL5_City.SelectedItem.Value.ToString());
            ColonyBal bal = new ColonyBal();
            DataSet dSet = bal.GetAllColonies(CityID);

            DDL6_Colony.DataSource = dSet;
            DDL6_Colony.DataTextField = "ColonyName";
            DDL6_Colony.DataValueField = "ColonyID";
            DDL6_Colony.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDL6_Colony.Items.Insert(0, li);
        }

        protected void DDL3_Country_SelectedIndexChanged1(object sender, EventArgs e)
        {
            BindStates1();

        }

        private void BindStates1()
        {
            int CountryID = Convert.ToInt32(DDL3_Country.SelectedItem.Value.ToString());
            StateBal Bal = new StateBal();
            DataSet dSet = Bal.GetAllStates(CountryID);

            DDL4_State.DataSource = dSet;
            DDL4_State.DataTextField = "StateName";

            DDL4_State.DataValueField = "StateID";

            DDL4_State.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");

            DDL4_State.Items.Insert(0, li);
        }

    }
}
    

    


















