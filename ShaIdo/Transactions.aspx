<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="ShaIdo.Transactions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="
        display: flex;
        width: 100%;
        height: 100%;
        justify-content: center;
    >
        <asp:Label CssClass="title" ID="lbl_transactions_title" runat="server" Text="Transactions"></asp:Label>
    </div>
    <div style="
        display: flex;
        width: 100%;
        height: 100%;
        justify-content: center;
    ">
        <asp:GridView ID="grd_transactions" runat="server" Width="100%" Height="100%" CssClass="auto-style1" OnSelectedIndexChanged="grdTransactions_SelectedIndexChanged">
        </asp:GridView>
    </div>
</asp:Content>
