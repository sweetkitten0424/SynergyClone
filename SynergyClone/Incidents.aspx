<%@ Page Title="Incidents" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Incidents</h2>
    <asp:GridView ID="IncidentsGrid" runat="server" AutoGenerateColumns="True" />
</asp:Content>