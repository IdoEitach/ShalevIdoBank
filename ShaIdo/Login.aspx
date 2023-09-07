<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShaIdo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="
            display: flex;
            flex-direction: column;
            width: 100%; 
            justify-content: center;
            align-items: center; 
            margin: 40px;
            ">
            <asp:Label CssClass="bold-label" ID="lbl_username" runat="server" Text="Username"></asp:Label>
            <asp:TextBox CssClass="txtbox txtbox-user" ID="txtbox_username" runat="server"></asp:TextBox>
            <br />
            <asp:Label CssClass="bold-label" ID="lbl_password" runat="server" Text="Password" ></asp:Label>
            <asp:TextBox CssClass="txtbox txtbox-password" ID="txtbox_password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button CssClass="button" runat="server" Text="login" OnClick="btn_login"></asp:Button>
            <label style="color: red;"><%=Session["error_login"] %></label>
        </div>
    </form>
</body>
</html>
