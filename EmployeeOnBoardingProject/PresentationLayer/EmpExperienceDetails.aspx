<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpExperienceDetails.aspx.cs" Inherits="EmployeeOnBoardingProject.PresentationLayer.EmpExperienceDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <h1 style="text-align:center;background-color:honeydew">&nbsp;Add Employeee Experience Details..!</h1>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color:darkseagreen;
            font-size:x-large
        }
        .auto-style2 {
            width: 267px;
        }
        .auto-style3 {
            width: 267px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 206px;
            height: 23px;
        }
        .auto-style6 {
            width: 128px;
            height: 23px;
        }
        .auto-style11 {
            width: 184px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="4">
                        <asp:Label ID="Label1" runat="server" Text="ExperienceDetailsID"></asp:Label>
                    </td>
                    <td colspan="4">
                        <asp:TextBox ID="TB1_EDID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">
                        <asp:Label ID="Label2" runat="server" Text="EmployeeName"></asp:Label>
                    </td>
                    <td colspan="4">
                        <asp:DropDownList ID="DDL1_EN" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">
                        <asp:Label ID="Label3" runat="server" Text="Organization"></asp:Label>
                    </td>
                    <td colspan="4">
                        <asp:TextBox ID="TB2_EON" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="4">
                        <asp:Label ID="Label4" runat="server" Text="DesignationName"></asp:Label>
                    </td>
                    <td class="auto-style4" colspan="4">
                        <asp:DropDownList ID="DDL2_EDN" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2">
                        <asp:Label ID="Label5" runat="server" Text="FromDate"></asp:Label>
                    </td>
                    <td class="auto-style3" colspan="2">
                        <asp:TextBox ID="TB3_EFD" runat="server"></asp:TextBox>
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="16px" ImageUrl="~/Images/OIP (1).jpeg" OnClick="ImageButton1_Click" />
                        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                            <OtherMonthDayStyle ForeColor="#CC9966" />
                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                            <SelectorStyle BackColor="#FFCC66" />
                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                        </asp:Calendar>
                    </td>
                    <td class="auto-style6" colspan="2">
                        <asp:Label ID="Label6" runat="server" Text="ToDate"></asp:Label>
                    </td>
                    <td class="auto-style4" colspan="2">
                        <asp:TextBox ID="TB4_ETD" runat="server"></asp:TextBox>
                        <asp:ImageButton ID="ImageButton2" runat="server" Height="16px" ImageUrl="~/Images/OIP (1).jpeg" Width="16px" OnClick="ImageButton2_Click" />
                        <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                            <OtherMonthDayStyle ForeColor="#CC9966" />
                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                            <SelectorStyle BackColor="#FFCC66" />
                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">
                        <asp:Label ID="Label8" runat="server" Text="Skills"></asp:Label>
                    </td>
                    <td colspan="4">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server"  RepeatColumns="3" RepeatDirection="Horizontal">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">&nbsp;</td>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:Button ID="Btn1_ADD" runat="server" Text="ADD" onclick="Btn1_ADD_Click" />
                    </td>
                    <td class="auto-style12" colspan="2">
                        <asp:button id="btn2_update" runat="server" text="UPDATE" OnClick="btn2_update_Click1"  />
                    </td>
                    <td class="auto-style13">
                        <asp:button id="btn3_delete" runat="server" text="DELETE" OnClick="btn3_delete_Click1"  />
                    </td>
                    <td>
                        <asp:Button ID="Btn4_CLEAR" runat="server" Text="CLEAR" OnClick="Btn4_CLEAR_Click1"   />
                    </td>
                    <td colspan="2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Btn5_NEXT" runat="server" Text="NEXT" OnClick="Btn5_NEXT_Click"  />
                    </td>
                </tr>
                </table>
            
                
            
            
                <br />
            <br />
            <br />
            <br />
            <br />
            
                
            
            
                <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="Horizontal" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server"></asp:Label>
            
            
        </div>
    </form>
</body>
</html>
