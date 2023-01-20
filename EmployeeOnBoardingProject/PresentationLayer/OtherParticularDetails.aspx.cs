using EmployeeOnBoardingProject.BusinessAccessLayer;
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
    public partial class OtherParticularDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetAllEmpIds();
                LoadGridView();
                GetAllRefEmpIds();

            }
        }

        private void LoadGridView()
        {
            EmpOtherparticularDetails OPD = new EmpOtherparticularDetails();
            OtherParticularDetailsBAL bal = new OtherParticularDetailsBAL();
            DataSet dSet = bal.GetALLOtherParticularDetails(OPD);
            dSet = bal.GetALLOtherParticularDetails(OPD);

            GridView1.DataSource = dSet;
            GridView1.DataBind();
        }




        private void GetAllEmpIds()
        {
            SalaryBreakUpDetailsBAL bal = new SalaryBreakUpDetailsBAL();
            DataSet dset = bal.GetAllEmpID();
            DDL_EName.DataSource = dset;
            DDL_EName.DataTextField = "EmployeeName";
            DDL_EName.DataValueField = "EmployeeID";
            DDL_EName.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDL_EName.Items.Insert(0, li);
        }


        private void GetAllRefEmpIds()

        {
            SalaryBreakUpDetailsBAL bal = new SalaryBreakUpDetailsBAL();
            DataSet dset = bal.GetAllEmpID();
            DDL_RefEN.DataSource = dset;
            DDL_RefEN.DataTextField = "EmployeeName";
            DDL_RefEN.DataValueField = "EmployeeID";
            DDL_RefEN.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDL_RefEN.Items.Insert(0, li);
        }

        protected void Btn_ADD_Click(object sender, EventArgs e)
        {
            EmpOtherparticularDetails OPD = new EmpOtherparticularDetails();
            OtherParticularDetailsBAL bal = new OtherParticularDetailsBAL();
            try
            {
                OPD.EmployeeID = Convert.ToInt32(DDL_EName.SelectedItem.Value);
                OPD.EarliestDOJ = Convert.ToDateTime(Txt_EDOJ.Text);
                OPD.CurrentSalary = Convert.ToInt32(Txt_CurrentSal.Text);
                OPD.ReferenceEmployeeID = Convert.ToInt32(DDL_RefEN.SelectedItem.Value);
                int counter = bal.ADDOtherParticularDetails(OPD);
                Label6.Text = "<h2>Employee's OtherParticularDetails added successfully..</h2>";
                LoadGridView();

            }
            catch (Exception ex)
            {

                Label5.Text = ex.Message;
            }
        }

        protected void Btn_UPDATE_Click(object sender, EventArgs e)
        {

            EmpOtherparticularDetails OPD = new EmpOtherparticularDetails();
            OtherParticularDetailsBAL bal = new OtherParticularDetailsBAL();
            try
            {
                OPD.OPDID = Convert.ToInt32(Txt_OPDID.Text);
                OPD.EmployeeID = Convert.ToInt32(DDL_EName.SelectedItem.Value);
                OPD.EarliestDOJ = Convert.ToDateTime(Txt_EDOJ.Text);
                OPD.CurrentSalary = Convert.ToInt32(Txt_CurrentSal.Text);
                OPD.ReferenceEmployeeID = Convert.ToInt32(DDL_RefEN.SelectedValue);
                int counter = bal.UpdateOtherParticularDetails(OPD);
                Label6.Text = "<h2>Employee's OtherParticularDetails updated successfully..</h2>";
                LoadGridView();

            }
            catch (Exception ex)
            {

                Label6.Text = ex.Message;
            }
        }

        protected void Btn_DELETE_Click(object sender, EventArgs e)
        {
            EmpOtherparticularDetails OPD = new EmpOtherparticularDetails();
            OtherParticularDetailsBAL bal = new OtherParticularDetailsBAL();
            try
            {
                OPD.EmployeeID = Convert.ToInt32(DDL_EName.SelectedItem.Value);
                int counter = bal.DeleteOtherParticularDetails(OPD);
                Label6.Text = "<h2>Employee's OtherParticularDetails updated successfully..</h2>";
                LoadGridView();



            }
            catch (Exception ex)
            {

                Label6.Text = ex.Message;
            }
        }

        protected void Btn_CLEAR_Click(object sender, EventArgs e)
        {
            Txt_OPDID.Text = string.Empty;
            DDL_EName.SelectedItem.Value = string.Empty;
            Txt_EDOJ.Text = string.Empty;
            Txt_CurrentSal.Text = string.Empty;
            DDL_RefEN.SelectedItem.Value = string.Empty;
        }

        protected void Btn_NEXT_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx.cs");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(Calendar1.SelectedDate.ToString());
            Txt_EDOJ.Text = dt.ToString("yyyy/MM/dd");
            Calendar1.Visible = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gvr = GridView1.SelectedRow;
            Txt_OPDID.Text = gvr.Cells[1].Text;
            DDL_EName.SelectedValue = gvr.Cells[2].Text;

            Txt_EDOJ.Text = gvr.Cells[3].Text;
            Txt_CurrentSal.Text = gvr.Cells[4].Text;
            DDL_RefEN.SelectedValue = gvr.Cells[5].Text;
        }
    }
}

    
