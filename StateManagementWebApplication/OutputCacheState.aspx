<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputCacheState.aspx.cs" Inherits="StateManagementWebApplication.OutputCacheState" %>
<%@ OutputCache Duration="120" VaryByParam="*" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="label" runat="server" />
    </form>
</body>
</html>
