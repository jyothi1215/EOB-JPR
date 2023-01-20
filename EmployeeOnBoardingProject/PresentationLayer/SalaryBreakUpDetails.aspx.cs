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
    public partial class SalaryBreakUpDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            { 
            GetAllEmpIds();
            LoadGridView();
            }
        }

        private void LoadGridView()
        {
            EmpSalBreakUpDetails Sbd = new EmpSalBreakUpDetails();
            SalaryBreakUpDetailsBAL Bal = new SalaryBreakUpDetailsBAL();
            DataSet dSet = Bal.GetAllSalaryBreakUpDetails(Sbd);

            dSet = Bal.GetAllSalaryBreakUpDetails(Sbd);

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

        protected void Btn_ADD_Click(object sender, EventArgs e)
        {
            EmpSalBreakUpDetails Sbd = new EmpSalBreakUpDetails();
            SalaryBreakUpDetailsBAL bal = new SalaryBreakUpDetailsBAL();
            try
            {
                Sbd.EmployeeID = Convert.ToInt32(DDL_EName.SelectedValue);
                Sbd.ParticularName = Txt_PName.Text;
                Sbd.ParticularAmount = Convert.ToInt32(Txt_PAmount.Text);
                int Counter = bal.ADDSalaryBreakUpDetails(Sbd);
                Label5.Text = "<h2>Employee's SalaryBreakUp Details added successfully..</h2>";
                LoadGridView();

            }
            catch (Exception ex)
            {

                Label5.Text = ex.Message;
            }
        }

        protected void Btn_UPDATE_Click(object sender, EventArgs e)
        {

            EmpSalBreakUpDetails Sbd = new EmpSalBreakUpDetails();
            SalaryBreakUpDetailsBAL bal = new SalaryBreakUpDetailsBAL();
            try
            {
                Sbd.SBDID = Convert.ToInt32(Txt_SBDID.Text);
                Sbd.EmployeeID = Convert.ToInt32(DDL_EName.SelectedItem.Value);
                Sbd.ParticularName = Txt_PName.Text;
                Sbd.ParticularAmount = Convert.ToInt32(Txt_PAmount.Text);
                int Counter = bal.UpdateSalaryBreakUpDetails(Sbd);
                Label5.Text = "<h2>Employee's SalaryBreakUp Details Updated successfully..</h2>";
                LoadGridView();

            }
            catch (Exception ex)
            {

                Label5.Text = ex.Message;
            }
        }

        protected void Btn_DELETE_Click(object sender, EventArgs e)
        {
            EmpSalBreakUpDetails Sbd = new EmpSalBreakUpDetails();
            SalaryBreakUpDetailsBAL bal = new SalaryBreakUpDetailsBAL();
            try
            {

                Sbd.EmployeeID = Convert.ToInt32(DDL_EName.SelectedItem.Value);
                int Counter = bal.DeleteSalaryBreakUpDetails(Sbd);
                Label5.Text = "<h2>Employee's SalaryBreakUp Details Deleted successfully..</h2>";
                LoadGridView();


            }
            catch (Exception ex)
            {

                Label5.Text = ex.Message;
            }
        }

        protected void Btn_CLEAR_Click(object sender, EventArgs e)
        {
            Txt_SBDID.Text = string.Empty;
            DDL_EName.SelectedItem.Text = string.Empty;
            Txt_PName.Text = string.Empty;
            Txt_PAmount.Text = string.Empty;



        }

        protected void Btn_NEXT_Click(object sender, EventArgs e)
        {
            Response.Redirect("OtherParticularDetails.aspx");
        }


        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow gvr = GridView1.SelectedRow;
            Txt_SBDID.Text = gvr.Cells[1].Text;
            if(gvr.Cells[2].Text.Trim().Length>0)
            DDL_EName.SelectedValue = gvr.Cells[2].Text;
            
            Txt_PName.Text = gvr.Cells[3].Text;
            Txt_PAmount.Text = gvr.Cells[4].Text;
            
        }
    }
}
    

    





