<%@ Page Title="Calendar" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Calendar Events</h2>
    <asp:GridView ID="CalendarGrid" runat="server" AutoGenerateColumns="True" />
</asp:Content>