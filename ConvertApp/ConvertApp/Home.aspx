<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ConvertApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Convert Number</title>
</head>
<body>
    <form id="frmConversion" runat="server">
        <table border="0"  cellpadding="0" cellspacing="0">
        <tr>
            <th colspan="2">
                Conversion
            </th>
        </tr>
        <tr>
            <td>
                Username
            </td>
            <td style="padding-right: 5px">
                <asp:TextBox  ID="txtUserName" runat="server" placeholder="Enter name"></asp:TextBox>
            </td>
            <td style="padding-right: 5px">
                <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtUsername" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Number
            </td>
            <td>
                <asp:TextBox  ID="txtNumber" runat="server" placeholder="Enter number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtNumber" runat="server" />
                <asp:RegularExpressionValidator ErrorMessage="Only numeric characters are allowed" ForeColor="Red" ControlToValidate="txtNumber" ValidationExpression="^[0-9.]+$" runat="server" />
            </td>
        </tr>
            <tr></tr>
        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
        </tr>
       </table>
        </form>
</body>
</html>
