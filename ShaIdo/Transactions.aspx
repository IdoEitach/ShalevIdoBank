<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="ShaIdo.Transactions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }

        .export {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display: flex; width: 100%; height: 100%; justify-content: center; align-items: center; flex-direction: column;">
        <asp:Label CssClass="title" ID="lbl_transactions_title" runat="server" Text="Transactions"></asp:Label>
        <div style="display: flex; height: 100%; justify-content: center; align-items: center; flex-direction: column; width: 200px;">
            <br />
            <div>Start </div>
            <input type="date" name="startDate" value="<%=Session["start_date"] %>">
            <div>End </div>
            <input type="date" name="endDate" value="<%=Session["end_date"] %>">
            <asp:Button CssClass="button" runat="server" OnClick="Search_Click" Text="Search" />
            <asp:Button runat="server" CssClass="button" OnClick="ToCSV_Click" Text="Export to CSV" />

        </div>
    </div>


    <div style="display: flex; width: 100%; height: 100%; justify-content: center;">
        <asp:GridView ID="grd_transactions" runat="server" Width="100%" Height="100%" CssClass="auto-style1"
            AutoGenerateColumns="false"
            OnRowEditing="grd_transactions_RowEditing"
            OnRowUpdating="grd_transactions_RowUpdating"
            OnRowUpdated="grd_transactions_RowUpdated"
            OnRowCancelingEdit="grd_transactions_RowCancelingEdit"
            DataKeyNames="Description" 
            AutoGenerateEditButton="true">
            <Columns>
                <%--<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />--%>
                <%--<asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />--%>
                <asp:BoundField DataField="TransactionId" HeaderText="Id" ReadOnly="true" SortExpression="TransactionId" />
                <asp:BoundField DataField="DatePosted" HeaderText="Date Posted" ReadOnly="true" SortExpression="CheckNumber" />
                <asp:BoundField DataField="Amount" HeaderText="Amount" ReadOnly="true" SortExpression="Amount" />
                <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="false" SortExpression="Description" />
                <asp:BoundField DataField="CheckNumber" HeaderText="Check Number" ReadOnly="true" SortExpression="CheckNumber" />
                <asp:BoundField DataField="Paying Account" HeaderText="Paying Account" ReadOnly="true" SortExpression="Paying Account" />
                <asp:BoundField DataField="Payee Account" HeaderText="Payee Account" ReadOnly="true" SortExpression="Payee Account" />
            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
