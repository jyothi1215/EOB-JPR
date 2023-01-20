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
    public partial class EmpExperienceDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetAllEmpID();
                GetDesignationsDetails();
                LoadGridView();
                //GetDesignationsDetailsbyID();
                GetAllSkills();
                Calendar1.Visible = false;
                Calendar2.Visible = false; 

            }
        }

        private void GetAllSkills()
        {
            SkillsBAL bal = new SkillsBAL();
            DataSet dset = bal.GetSkillsDetails();
            CheckBoxList1.DataSource = dset;
            CheckBoxList1.DataTextField = "SkillName";
            CheckBoxList1.DataValueField = "SkillID";
            CheckBoxList1.DataBind();
            //ListItem li = new ListItem("Please Select", "Please Select");
            //CheckBoxList1.Items.Insert(0, li);
        }

        private void GetDesignationsDetailsbyID(Designations Dd)
        {
            DesignationsBAL bal = new DesignationsBAL();
            DataSet dset = bal.GetDesignationsDetailsbyID(Dd);
            DDL2_EDN.DataSource = dset;
            DDL2_EDN.DataTextField = "DesignationName";
            DDL2_EDN.DataValueField = "DesignationID";
            DDL2_EDN.DataBind();

        }

        private void LoadGridView()
        {
            ExperienceDetails Exd = new ExperienceDetails();
            Emp_ExperienceDetailsBAL bal = new Emp_ExperienceDetailsBAL();
            DataSet dSet = bal.GetAllEmpExperienceDetails(Exd);

            dSet = bal.GetAllEmpExperienceDetails(Exd);

            GridView1.DataSource = dSet.Tables[0].DefaultView; 
            GridView1.DataBind();
        }

        private void GetDesignationsDetails()
        {
            DesignationsBAL bal = new DesignationsBAL();
            DataSet dset = bal.GetDesignationsDetails();
            DDL2_EDN.DataSource = dset;
            DDL2_EDN.DataTextField = "DesignationName";
            DDL2_EDN.DataValueField = "DesignationID";
            DDL2_EDN.DataBind();
            ListItem li = new ListItem("Please Select", "Please Select");
            DDL2_EDN.Items.Insert(0, li);

        }

        private void GetAllEmpID()
        {
            EmpAcademicDetailsBAL bal = new EmpAcademicDetailsBAL();
            DataSet dset = bal.GetAllEmpID();
            DDL1_EN.DataSource = dset;
            DDL1_EN.DataTextField = "EmployeeName";
            DDL1_EN.DataValueField = "EmployeeID";
            DDL1_EN.DataBind();

            ListItem li = new ListItem("Please Select", "Please Select");
            DDL1_EN.Items.Insert(0, li);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(Calendar1.SelectedDate.ToString());
            TB3_EFD.Text = dt.ToString("yyyy/MM/dd");
            Calendar1.Visible = false;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(Calendar1.SelectedDate.ToString());
            TB4_ETD.Text = dt.ToString("yyyy/MM/dd");
            Calendar2.Visible = false;

        }

        protected void Btn1_ADD_Click(object sender, EventArgs e)
        {
            ExperienceDetails Exd = new ExperienceDetails();
            Emp_ExperienceDetailsBAL bal = new Emp_ExperienceDetailsBAL();
            try
            {
                Exd.EmployeeID = Convert.ToInt32(DDL1_EN.SelectedValue);
                Exd.Organization = TB2_EON.Text.ToString();
                Exd.DesignationID = Convert.ToInt32(DDL2_EDN.SelectedItem.Value);
                Exd.FromDate = Convert.ToDateTime(TB3_EFD.Text);
                Exd.ToDate = Convert.ToDateTime(TB4_ETD.Text);

                string str = string.Empty;
                for(int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected == true)
                    {
                        if (str.Length == 0)
                        
                            str = CheckBoxList1.Items[i].Value.ToString();
                             else
                                str += "," + CheckBoxList1.Items[i].Value.ToString();
                            
                        
                        


                    }

                }
                Exd.SkillID = str;
                int Counter = bal.ADDEmpExperienceDetails(Exd);
                Label7.Text = "<h2>Employee's ExperienceDetails added successfully..</h2>";
                LoadGridView();

            }
            catch (Exception ex)
            {

                Label7.Text = ex.Message;
            }
        }
        
        

        protected void Btn5_NEXT_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalaryBreakUpDetails.aspx");
        }



        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow gvr = GridView1.SelectedRow;
            TB1_EDID.Text = gvr.Cells[1].Text;

            foreach (ListItem item in DDL1_EN.Items)
            {

                if (gvr.Cells[2].Text.Trim() == item.Value)
                {
                    DDL1_EN.SelectedItem.Value = gvr.Cells[2].Text.Trim();
                    DDL1_EN.SelectedItem.Text = item.Text;

                }
            }
            foreach (ListItem item in DDL2_EDN.Items)
            {

                if (gvr.Cells[4].Text.Trim() == item.Value)
                {
                    DDL2_EDN.SelectedItem.Value = gvr.Cells[4].Text.Trim();
                    DDL2_EDN.SelectedItem.Text = item.Text;

                }
            }



            TB2_EON.Text = gvr.Cells[3].Text;
            TB3_EFD.Text = gvr.Cells[5].Text;

            TB4_ETD.Text = gvr.Cells[6].Text;

             foreach (ListItem item in CheckBoxList1.Items)

              {
                String str = gvr.Cells[7].Text;
                string[] strsplit = str.Split(',');
                foreach (string stritem in strsplit)
                {
                    if (stritem.Trim() == item.Value)
                CheckBoxList1.Items.FindByValue(item.Value).Selected = true;

                }
                

             }

        }

        protected void btn2_update_Click1(object sender, EventArgs e)
        {
            ExperienceDetails Exd = new ExperienceDetails();
            Emp_ExperienceDetailsBAL bal = new Emp_ExperienceDetailsBAL();
            try
            {

                Exd.ExperienceDetailsID = Convert.ToInt32(TB1_EDID.Text);
                Exd.EmployeeID = Convert.ToInt32(DDL1_EN.SelectedItem.Value);
                Exd.Organization = TB2_EON.Text;
                Exd.DesignationID = Convert.ToInt32(DDL2_EDN.SelectedItem.Value);
                Exd.FromDate = Convert.ToDateTime(TB3_EFD.Text);
                Exd.ToDate = Convert.ToDateTime(TB4_ETD.Text);
                string str = string.Empty;
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        if (str.Length == 0)
                            str = CheckBoxList1.Items[i].Value.ToString();
                        else
                            str += "," + CheckBoxList1.Items[i].Value.ToString();
                    }
                }

                    Exd.SkillID = str;
                    int Counter = bal.UpdateEmpExperienceDetails(Exd);
                    Label7.Text = "<h2>Employee's Experience Details updated successfully..</h2>";
                    LoadGridView();
                
            }

            catch (Exception ex)
            {

                Label7.Text = ex.Message;
            }
        }

        protected void btn3_delete_Click1(object sender, EventArgs e)
        {
            ExperienceDetails Exd = new ExperienceDetails();
            Emp_ExperienceDetailsBAL bal = new Emp_ExperienceDetailsBAL();
            try
            {
                Exd.EmployeeID = Convert.ToInt32(DDL1_EN.SelectedValue);
                int Counter = bal.DeleteEmpExperienceDetails(Exd);
                Label7.Text = "<h2>Employee's Experience Details Deleted successfully..</h2>";
                LoadGridView();
            }
            catch (Exception ex)
            {

                Label7.Text = ex.Message;
            }
        }

        protected void Btn4_CLEAR_Click1(object sender, EventArgs e)
        {
            TB1_EDID.Text = "";
            DDL1_EN.SelectedIndex=0;
            TB2_EON.Text = "";
            DDL2_EDN.SelectedIndex=0;
            TB3_EFD.Text = "";
            TB4_ETD.Text = "";
            CheckBoxList1.SelectedValue = "";

            Label7.Text = "<h2>Please Enter Employee's Details</h2>";

        }
        
    }
}



        

    
