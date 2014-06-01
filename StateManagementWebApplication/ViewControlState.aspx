<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewControlState.aspx.cs" Inherits="StateManagementWebApplication.ViewControlState"    
 EnableViewState="false" %>
    
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <ctrl:WebCustomControl runat="server" id="control" />
        </div>
        <div>
            <asp:Button runat="server" Text="do post" />
        </div>
        <div>
            <asp:Label runat="server" ID="message" />
        </div>
    </div>
    </form>
</body>
</html>
