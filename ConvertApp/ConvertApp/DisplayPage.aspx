<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayPage.aspx.cs" Inherits="ConvertApp.DisplayPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmDisplay" runat="server">
    <div>
    <asp:Label ID="lblOne" runat="server" Font-Bold="true">User name is:</asp:Label>
    &nbsp;
    <asp:Label ID="lblName" runat="server"></asp:Label>
        <br/>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="true">Number in words:</asp:Label>
         &nbsp;
    <asp:Label ID="lblWord" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
