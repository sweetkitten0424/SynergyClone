<%@ Page Title="Messages" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Messages</h2>
    <asp:GridView ID="MessagesGrid" runat="server" AutoGenerateColumns="True" />
</asp:Content>