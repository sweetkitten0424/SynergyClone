<%@ Page Title="Test Scores" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Test Scores</h2>
    <asp:GridView ID="TestScoresGrid" runat="server" AutoGenerateColumns="True" />
</asp:Content>