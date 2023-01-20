<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtherParticularDetails.aspx.cs" Inherits="EmployeeOnBoardingProject.PresentationLayer.OtherParticularDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

        <style type="text/css">
            .auto-style1 {
                width: 100%;
                border: 2px solid #000000;
                background-color:lightyellow;
                font-size:x-large
            }
            .auto-style2 {
                width: 330px;
            }
            .auto-style3 {
                width: 259px;
            }
            .auto-style4 {
                width: 151px;
            }
            .auto-style5 {
                width: 189px;
            }
            .auto-style6 {
                width: 242px;
            }
        </style>

        <h1 style="text-align:center;background-color:honeydew">&nbsp;Add Employee OtherParticularDetails..</h1>

    
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="OPDID"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="Txt_OPDID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Label ID="Label2" runat="server" Text="EmployeeName"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:DropDownList ID="DDL_EName" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Label ID="Label3" runat="server" Text="EarliestDOJ"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="Txt_EDOJ" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="16px" ImageUrl="~/Images/OIP (1).jpeg" OnClick="ImageButton1_Click" Width="17px" />
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged" ShowGridLines="True" Width="220px">
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
                <td class="auto-style2" colspan="3">
                    <asp:Label ID="Label4" runat="server" Text="CurrentSalary"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="Txt_CurrentSal" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Label ID="Label5" runat="server" Text="RefEmployeeName"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:DropDownList ID="DDL_RefEN" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Btn_ADD" runat="server" Text="ADD" OnClick="Btn_ADD_Click"  />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Btn_UPDATE" runat="server" Text="UPDATE" OnClick="Btn_UPDATE_Click" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Btn_DELETE" runat="server" Text="DELETE" OnClick="Btn_DELETE_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Btn_CLEAR" runat="server" Text="CLEAR" OnClick="Btn_CLEAR_Click" />
                </td>
                <td>
                    <asp:Button ID="Btn_NEXT" runat="server" Text="NEXT" OnClick="Btn_NEXT_Click" />
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Vertical" Width="370px" ForeColor="Black" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    <p>
        &nbsp;</p>
        <asp:Label ID="Label6" runat="server"></asp:Label>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
