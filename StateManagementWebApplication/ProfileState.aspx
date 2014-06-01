<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfileState.aspx.cs" Inherits="StateManagementWebApplication.ProfileState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="profileDescription" />
    </div>
    <div>
        <div>
            <label>Name: </label>
            <asp:TextBox runat="server" ID="nametextBox" />
        </div>
        <div>
            <label>Email: </label>
            <asp:TextBox runat="server" ID="emailTextBox" />
        </div>
        <div>
            <label>Bithday: </label>
            <asp:Calendar runat="server" ID="birthdayCalendar" />
        </div>
        <div>
            <asp:Button runat="server" ID="createBtn" Text="CreateProfile" OnClick="createBtn_Click"/>
            <asp:Button runat="server" ID="showBtn" Text="Show" OnClick="showBtn_Click" />
        </div>
    </div>
    </form>
</body>
</html>
