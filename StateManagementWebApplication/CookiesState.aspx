<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookiesState.aspx.cs" Inherits="StateManagementWebApplication.CookiesState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="label" runat="server" />
        <asp:TextBox ID="textBox" runat="server" />
        <asp:Button ID="btn" runat="server" OnClick="btn_Click" />
    </form>
</body>
</html>
