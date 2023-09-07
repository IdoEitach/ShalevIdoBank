<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShaIdo.Login2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div style="width: 100%; height: 100%; display: flex; justify-content: center; align-items: center;">

            <div style="
            display: flex;
            flex-direction: column;
            width: 350px; 
            justify-content: center;
            align-items: center; 
            margin: 40px;
            ">
            <asp:Label CssClass="bold-label" ID="lbl_username" runat="server" Text="Username"></asp:Label>
            <asp:TextBox CssClass="txtbox txtbox-user" ID="txtbox_username" runat="server"></asp:TextBox>
            <br />
            <asp:Label CssClass="bold-label" ID="lbl_password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox CssClass="txtbox txtbox-password" ID="txtbox_password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button CssClass="button" runat="server" Text="login" OnClick="btn_login"></asp:Button>
            <label style="color: red;"><%=Session["error_login"] %></label>
        </div>
                </div>
</asp:Content>
