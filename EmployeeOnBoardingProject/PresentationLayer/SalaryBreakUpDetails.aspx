<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalaryBreakUpDetails.aspx.cs" Inherits="EmployeeOnBoardingProject.PresentationLayer.SalaryBreakUpDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #CCFFCC;
            font-size:x-large
        }
        .auto-style2 {
            width: 459px;
        }
        .auto-style4 {
            width: 172px;
        }
        .auto-style6 {
            width: 214px;
        }
        .auto-style7 {
            width: 183px;
        }
        .auto-style8 {
            width: 209px;
        }
    </style>
    <h1 style="text-align:center;background-color:honeydew">&nbsp;Add Employee SalarybreakUpDetails..</h1>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="309px" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <br />
        
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="SBDID"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="Txt_SBDID" runat="server"></asp:TextBox>
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
                    <asp:Label ID="Label3" runat="server" Text="ParticularName"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="Txt_PName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Label ID="Label4" runat="server" Text="ParticularAmount"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="Txt_PAmount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="Btn_ADD" runat="server" Text="ADD" OnClick="Btn_ADD_Click"  />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Btn_UPDATE" runat="server" Text="UPDATE" OnClick="Btn_UPDATE_Click" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Btn_DELETE" runat="server" Text="DELETE" OnClick="Btn_DELETE_Click" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Btn_CLEAR" runat="server" Text="CLEAR" OnClick="Btn_CLEAR_Click" />
                </td>
                <td>
                    <asp:Button ID="Btn_NEXT" runat="server" Text="NEXT" OnClick="Btn_NEXT_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>

            </div>
        
    </form>
    
</body>
</html>
