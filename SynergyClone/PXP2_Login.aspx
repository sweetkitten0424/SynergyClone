<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="PXP2_Login.aspx.cs" Inherits="SynergyClone.PXP2_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- TODO: Implement Synergy Staff Login -->
    <asp:TextBox ID="username" runat="server" Placeholder="Username" />
    <asp:TextBox ID="password" runat="server" TextMode="Password" Placeholder="Password" />
    <asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="btnLogin_Click" />
</asp:Content>