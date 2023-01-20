<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpAcademicDetails.aspx.cs" Inherits="EmployeeOnBoardingProject.PresentationLayer.EmpAcademicDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h1>Add Employee AcademicDetails..</h1>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
            background-color:azure;
            font-size:x-large
            
        }
        .auto-style2 {
            width: 330px;
        }
        .auto-style3 {
            width: 330px;
            height: 14px;
        }
        .auto-style4 {
            height: 14px;
        }
        .auto-style5 {
            width: 135px;
        }
        .auto-style6 {
            width: 184px;
        }
        .auto-style7 {
            width: 179px;
        }
        .auto-style8 {
            width: 330px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" GridLines="None" AllowPaging="True" AutoGenerateSelectButton="True" Height="16px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="557px" OnPageIndexChanging="GridView1_PageIndexChanging" ForeColor="#333333" PageSize="1">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <br />
            <br />
            <table class="auto-style1" >
                
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="Label2" runat="server" Text="ADNO"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TB1ADNO" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="2">
                        <asp:Label ID="Label3" runat="server" Text="EmployeeName"></asp:Label>
                    </td>
                    <td colspan="3" class="auto-style9">
                        <asp:DropDownList ID="DDLEMPNAME" runat="server" >
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DDLEMPNAME" ErrorMessage="EmployeeName is  Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="Label4" runat="server" Text="Qualification"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:DropDownList ID="DDLEQ" runat="server">
                            <asp:ListItem>Please Select</asp:ListItem>
                            <asp:ListItem>B.COM</asp:ListItem>
                            <asp:ListItem>MCA</asp:ListItem>
                            <asp:ListItem>MBA</asp:ListItem>
                            <asp:ListItem>MSC</asp:ListItem>
                            <asp:ListItem>B.TECH</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="Label5" runat="server" Text="University"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="DDLEU">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4" colspan="3">
                        <asp:DropDownList ID="DDLEU" runat="server" OnSelectedIndexChanged="DDL1_EU_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="Label6" runat="server" Text="College"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="DDLEC">*</asp:RequiredFieldValidator>
                    </td>
                    <td colspan="3">
                        <asp:DropDownList ID="DDLEC" runat="server" >
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="Label7" runat="server" Text="Academic Year"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TB3EAY" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="..." OnClick="Button1_Click" />
                        <asp:Calendar ID="Calendar1"  Visible="false" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="Label8" runat="server" Text="Percentage"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TB4EP" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Button ID="Btn_Add" runat="server" Text="ADD" OnClick="Bt1_Add_Click"  />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="Btn_Update" runat="server" Text="Update" OnClick="Bt2_Update_Click" />
                    </td>
                    <td class="auto-style7">
                        <asp:Button ID="Btn_Delete" runat="server" Text="Delete" OnClick="Bt3_Delete_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Btn_Clear" runat="server" Text="Clear" OnClick="Button2_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Btn_Next" runat="server" OnClick="Button3_Click" Text="Next" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="Label9" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            &nbsp;<br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
