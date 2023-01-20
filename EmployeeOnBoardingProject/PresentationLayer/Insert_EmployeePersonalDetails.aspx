<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_EmployeePersonalDetails.aspx.cs" Inherits="EmployeeOnBoardingProject.PresentationLayer.Insert_EmployeePersonalDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h1>Add Employee PersonalDetails...!</h1>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
           
            
            
        }
        .auto-style2 {
            width: 358px;
            font-size:x-large;
        }
        .auto-style5 {
            width: 114px;
        }
        .auto-style6 {
            width: 158px;
        }
        .auto-style9 {
            width: 358px;
            height: 7px;
        }
        .auto-style10 {
            height: 7px;
        }
        .auto-style11 {
            width: 330px;
        }
        .auto-style12 {
            width: 256px;
            height: 60px;
        }
        .auto-style13 {
            width: 358px;
            height: 29px;
        }
        .auto-style14 {
            height: 29px;
        }
        .auto-style15 {
            width: 358px;
            height: 60px;
        }
        .auto-style16 {
            height: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="575px" ForeColor="Black" AllowPaging="True" GridLines="Vertical" PageSize="5">
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
            <br />
            <br />
            <br />
            <table class="auto-style1" style="font-size:large">
                
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label1" runat="server" Text="EmployeeID" Font-Size="Large"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label2" runat="server" Text="EmployeeFirstName"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label3" runat="server" Text="EmployeeMiddleName"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label4" runat="server" Text="EmployeeSurName"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label5" runat="server" Text="BloodGroup"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:DropDownList ID="DDL1_Bloodgroup" runat="server" >
                            <asp:ListItem>Select Your BloodGroup</asp:ListItem>
                            <asp:ListItem>O-</asp:ListItem>
                            <asp:ListItem>O+</asp:ListItem>
                            <asp:ListItem>A-</asp:ListItem>
                            <asp:ListItem Value="A+"></asp:ListItem>
                            <asp:ListItem>B-</asp:ListItem>
                            <asp:ListItem Value="B+"></asp:ListItem>
                            <asp:ListItem Value="AB-"></asp:ListItem>
                            <asp:ListItem>AB+</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label6" runat="server" Text="DateOfBirth"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label7" runat="server" Text="PhoneNo"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label8" runat="server" Text="AlternatePhoneNo"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label9" runat="server" Text="MailID"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label10" runat="server" Text="MaritalStatus"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:DropDownList ID="DDL2_MaritalStatus" runat="server">
                            <asp:ListItem>Select Your MaritalStatus</asp:ListItem>
                            <asp:ListItem>Single</asp:ListItem>
                            <asp:ListItem>Married</asp:ListItem>
                            <asp:ListItem>Divorced</asp:ListItem>
                            <asp:ListItem>Widowed</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15" colspan="3">
                        <asp:Label ID="Label11" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:RadioButtonList ID="Rdb_Gender"  runat="server" >
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Others</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td colspan="2" class="auto-style16">
                        </td>
                </tr>
                <tr>
                    <td class="auto-style9" colspan="3">
                        <asp:Label ID="Label12" runat="server" Text="PermanentCountryName"></asp:Label>
                    </td>
                    <td colspan="3" class="auto-style10">
                        <asp:DropDownList ID="DDL3_Country" runat="server"  DataTextField="CountryName" DataValueField="CountryID" AutoPostBack="True" OnSelectedIndexChanged="DDL3_Country_SelectedIndexChanged1" >
                            <asp:ListItem>Select Your Country</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label13" runat="server" Text="PermanentStateName"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:DropDownList ID="DDL4_State" runat="server"  DataTextField="StateName" DataValueField="CountryID"  AutoPostBack="True" OnSelectedIndexChanged="DDL4_State_SelectedIndexChanged">
                            <asp:ListItem>Select Your State</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13" colspan="3">
                        <asp:Label ID="Label14" runat="server" Text="PermanentCityName"></asp:Label>
                    </td>
                    <td colspan="3" class="auto-style14">
                        <asp:DropDownList ID="DDL5_City" runat="server"  DataTextField="CityName" DataValueField="StateID" AutoPostBack="True" OnSelectedIndexChanged="DDL5_City_SelectedIndexChanged"  >
                            <asp:ListItem>Select Your City</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label15" runat="server" Text="PermanentColonyName"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:DropDownList ID="DDL6_Colony" runat="server"  DataTextField="ColonyName" DataValueField="CityID" AutoPostBack="True" >
                            <asp:ListItem>Select Your Colony</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label16" runat="server" Text="PermanentHouseNo"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label17" runat="server" Text="TemporaryCountryName"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:DropDownList ID="DDL7_TempCountry" runat="server"  DataTextField="CountryName" DataValueField="CountryID" OnSelectedIndexChanged="DDL7_TempCountry_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>Select Your Country</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label18" runat="server" Text="TemporaryStateName"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:DropDownList ID="DDL8_TempState" runat="server"  DataTextField="StateName" DataValueField="CountryID" OnSelectedIndexChanged="DDL8_TempState_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>Select Your State</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label19" runat="server" Text="TemporaryCityName"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:DropDownList ID="DDL9_TempCity" runat="server"  DataTextField="CityName" DataValueField="StateID" OnSelectedIndexChanged="DDL9_TempCity_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>Select Your City</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label20" runat="server" Text="TemporaryColonyName"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:DropDownList ID="DDL10_TempColony" runat="server"  DataTextField="ColonyName" DataValueField="CityID" AutoPostBack="True" >
                            <asp:ListItem>Select Your Colony</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label21" runat="server" Text="TemporaryHouseNO"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Button ID="Btn1_Insert" runat="server"  Text="Insert" OnClick="Btn1_Insert_Click" />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="Btn2_Update" runat="server" Text="Update" OnClick="Btn2_Update_Click"  />
                    </td>
                    <td class="auto-style11">
                        <asp:Button ID="Btn3_Delete" runat="server" Text="Delete" OnClick="Btn3_Delete_Click" />
                    </td>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Clear" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Next" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="Label22" runat="server"></asp:Label>
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
