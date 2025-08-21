<%@ Page Title="Health" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Health Records</h2>
    <asp:GridView ID="HealthGrid" runat="server" AutoGenerateColumns="True" />
</asp:Content>