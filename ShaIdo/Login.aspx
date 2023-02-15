<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShaIdo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="lbl_username" runat="server" Text="username"></asp:Label>
            </div>
            <asp:TextBox ID="txtbox_username" runat="server"></asp:TextBox>
        </div>
        <div>
            <div>
                <asp:Label ID="lbl_password" runat="server" Text="password"></asp:Label>
            </div>
            <asp:TextBox ID="txtbox_password" runat="server"></asp:TextBox>
            <asp:Button runat="server" Text="login" OnClick="btn_login"></asp:Button>

        </div>
    </form>
</body>
</html>
