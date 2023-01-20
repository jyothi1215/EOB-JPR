using EmployeeOnBoardingProject.BusinessAccessLayer;
using EmployeeOnBoardingProject.DataAccessLayer;
using EmployeeOnBoardingProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeOnBoardingProject.PresentationLayer
{
    public partial class EmpAcademicDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                LoadUniversities();
                GetAllColleges();
                GetAllEmpID();
                LoadGridview();

            }
        }

        private void GetAllColleges()
        {
            CollegesBal bal = new CollegesBal();
            DataSet dSet = bal.GetAllColleges();
            DDLEC.DataSource = dSet;
            DDLEC.DataTextField = "CollegeName";
            DDLEC.DataValueField = "CollegeID";
            DDLEC.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDLEC.Items.Insert(0, li);
        }

        private void LoadGridview()
        {
            AcademicDetails Ad = new AcademicDetails ();
            EmpAcademicDetailsBAL bal = new EmpAcademicDetailsBAL();
            DataSet dSet = bal.GetAllEmpAcademicDetails(Ad);

            dSet = bal.GetAllEmpAcademicDetails(Ad);

            GridView1.DataSource = dSet;
            GridView1.DataBind();

        }

        private void GetAllEmpID()
        {
            EmpAcademicDetailsBAL bal = new EmpAcademicDetailsBAL();
            DataSet dset = bal.GetAllEmpID();
            DDLEMPNAME.DataSource = dset;
            DDLEMPNAME.DataTextField = "EmployeeName";
            DDLEMPNAME.DataValueField = "EmployeeID";
            DDLEMPNAME.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDLEMPNAME.Items.Insert(0, li);

        }

        private void LoadUniversities()
        {
            UniversitiesBAL bal = new UniversitiesBAL();
            DataSet dSet = bal.GellAllUniversities();
            DDLEU.DataSource = dSet;
            DDLEU.DataTextField = "UniversityName";
            DDLEU.DataValueField = "UniversityID";
            DDLEU.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDLEU.Items.Insert(0, li);
        }

        

    protected void Bt1_Add_Click(object sender, EventArgs e)
        {
            AcademicDetails Ad = new AcademicDetails();
            EmpAcademicDetailsBAL bal = new EmpAcademicDetailsBAL();
            {
                try
                {

                    //Ad.AcademicDetailsID = Convert.ToInt32(TB1_ADNO.Text);
                    Ad.EmployeeID = Convert.ToInt32(DDLEMPNAME.SelectedItem.Value);
                    Ad.Qualification = DDLEQ.SelectedItem.Value;
                    Ad.UniversityID = Convert.ToInt32(DDLEU.SelectedItem.Value);
                    Ad.CollegeID = Convert.ToInt32(DDLEC.SelectedItem.Value);
                    Ad.Year = DateTime.Parse(TB3EAY.Text);
                    Ad.Percentage = Convert.ToDecimal(TB4EP.Text);
                    



                    int Counter = bal.ADD_EmpAcademicDetails(Ad);
                    LoadGridview();

                    Label9.Text = "<h2>Employee's Academic Details added successfully..</h2>";





                }
                catch (Exception ex)
                {

                    Label9.Text = ex.Message;
                }
            }

        }



        protected void DDL1_EU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int UniversityID = Convert.ToInt32(DDLEU.SelectedItem.Value.ToString());
            CollegesBal bal = new CollegesBal();
            DataSet dSet = bal.GetAllCollegesByUniversityID(UniversityID);

            DDLEC.DataSource = dSet;
            DDLEC.DataTextField = "CollegeName";
            DDLEC.DataValueField = "CollegeID";
            DDLEC.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDLEC.Items.Insert(0, li);


        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(Calendar1.SelectedDate.ToString());
            TB3EAY.Text = dt.ToString("yyyy/MM/dd");
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Bt2_Update_Click(object sender, EventArgs e)
        {

            AcademicDetails Ad = new AcademicDetails();
            EmpAcademicDetailsBAL bal = new EmpAcademicDetailsBAL();
            {
                try
                {

                    Ad.AcademicDetailsID = Convert.ToInt32(TB1ADNO.Text);
                    Ad.EmployeeID = Convert.ToInt32(DDLEMPNAME.SelectedItem.Value);
                    Ad.Qualification = DDLEQ.SelectedItem.Value;
                    Ad.UniversityID = Convert.ToInt32(DDLEU.SelectedItem.Value);
                    Ad.CollegeID = Convert.ToInt32(DDLEC.SelectedItem.Value);
                    Ad.Year = DateTime.Parse(TB3EAY.Text);
                    Ad.Percentage = Convert.ToDecimal(TB4EP.Text);
                    



                    int Counter = bal.Update_EmpAcademicDetails(Ad);
                    LoadGridview();

                    Label9.Text = "<h2>Employee's Academic Details Updated successfully..</h2>";
                }
                catch (Exception ex)
                {

                    Label9.Text = ex.Message;
                }
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gvr = GridView1.SelectedRow;
            TB1ADNO.Text = gvr.Cells[1].Text;

            foreach (ListItem item in DDLEMPNAME.Items)
            {

                if (gvr.Cells[2].Text.Trim() == item.Value)
                {
                    DDLEMPNAME.SelectedItem.Value = gvr.Cells[2].Text.Trim();
                    DDLEMPNAME.SelectedItem.Text = item.Text;

                }
            }
            foreach (ListItem item in DDLEQ.Items)
            {

                if (gvr.Cells[3].Text.Trim() == item.Value)
                {
                    DDLEQ.SelectedItem.Value = gvr.Cells[3].Text.Trim();
                    DDLEQ.SelectedItem.Text = item.Text;

                }
            }
            foreach (ListItem item in DDLEU.Items)
            {

                if (gvr.Cells[4].Text.Trim() == item.Value)
                {
                    DDLEU.SelectedItem.Value = gvr.Cells[4].Text.Trim();
                    DDLEU.SelectedItem.Text = item.Text;

                }
            }
            foreach (ListItem item in DDLEC.Items)
            {

                if (gvr.Cells[5].Text.Trim() == item.Value)
                {
                    DDLEC.SelectedItem.Value = gvr.Cells[5].Text.Trim();
                    DDLEC.SelectedItem.Text = item.Text;

                }
            }

            
            TB3EAY.Text = gvr.Cells[6].Text;
            TB4EP.Text = gvr.Cells[7].Text;
        }

        protected void Bt3_Delete_Click(object sender, EventArgs e)
        {
            AcademicDetails Ad = new AcademicDetails();
            EmpAcademicDetailsBAL bal = new EmpAcademicDetailsBAL();
            try
            {

                Ad.AcademicDetailsID = Convert.ToInt32(TB1ADNO. Text.ToString());
                int Counter = bal.DeleteEmpDetails(Ad);

                Label9.Text = "<h2>Employee's Personal Details Deleted successfully..</h2>";

            }

            catch (Exception ex)
            {
                Label9.Text = ex.Message;

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpExperienceDetails.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TB1ADNO.Text = string.Empty;
            DDLEMPNAME.SelectedItem.Value = string.Empty;
            DDLEQ.SelectedItem.Value = string.Empty;
            DDLEU.SelectedItem.Value = string.Empty;
            DDLEC.SelectedItem.Value = string.Empty;
            TB3EAY.Text = string.Empty;
            TB4EP.Text = string.Empty;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadGridview();
        }
    }
}
    

    
